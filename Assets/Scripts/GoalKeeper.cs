using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public GameObject soccerBall;
    public GameObject Post;
    public GameObject controller;
    private float startTime;
    private bool moveController=false;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        cam = GameObject.Find("Camera").GetComponent<Camera>();

    }
    private Vector2 targetPos;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            resetScene();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPos = calcBallTargetPos(Input.mousePosition.x,Input.mousePosition.y);
        }

        if (moveController)
        {
            Vector3 relativeBallPos = new Vector3((targetPos.x - 2.2f) * -1, targetPos.y - 5.6f + 1f, 0);
            //move parent so characters arms connect to target ball position
            Debug.Log("play anim = true Controller pos: " + controller.transform.position);

            controller.transform.position = Vector3.Lerp(new Vector3(0, 1, 0), relativeBallPos, (Time.time - startTime) / 0.56f);

        }


    }

    public void resetScene()
    {
        controller.transform.position = new Vector3(0, 1, 0);
        controller.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        moveController = false;

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(0, 0, 0);
        

        soccerBall.transform.position = new Vector3(0, 0.11f, 11);
        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(0,0 ,0);
        soccerBall.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        soccerBall.GetComponent<GoalDetection>().setGoalStatusFalse();

        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public Vector2 calcBallTargetPos(float mousePosX, float mousePosY)
    {

    

        Vector2 shootVelocities = calcShootVelocities(mousePosX, mousePosY);


        shootBall(shootVelocities);

        return shootVelocities;
    }

    public void shootBall(Vector2 targetPos)
    {
        Debug.Log(targetPos);
        PlayAnimation(-targetPos.x, targetPos.y);



        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(-targetPos.x, targetPos.y, -10f);
        Debug.Log("TimeShoot: "+Time.time);

    }


    public Vector2 calcShootVelocities(float mousePosX, float mousePosY)
    {
        float MOUSE_ERROR_X = -15f;
        float MOUSE_ERROR_Y = 15f;

        mousePosX -= MOUSE_ERROR_X;
        mousePosY -= MOUSE_ERROR_Y;

        


        float postRightX = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("PostRight").transform.position).x;
        float postLeftX = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("PostLeft").transform.position).x;

        float shootingAngleX = Utilities.mapToRange(mousePosX, postRightX, postLeftX, -Post.transform.position.x +0.3f, Post.transform.position.x-0.3f);


        float crossBarPosY = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("CrossBar").transform.position).y;
        float groundPosY = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Ground").transform.position).y;

        float shootingAngleY = Utilities.mapToRange(mousePosY, groundPosY, crossBarPosY, 4.8f, 7.4f);


        Vector3 predictedTargetLoc = cam.ScreenToWorldPoint(new Vector3(shootingAngleX, shootingAngleY, 0));
        Debug.Log("Predicted Loc:" + new Vector3(shootingAngleX, shootingAngleY, 0));
        


        return new Vector2(shootingAngleX, shootingAngleY);
    }

    
    
    private void PlayAnimation(float targetPositionX, float targetPositionY)
    {

        this.anim.SetTrigger(calculateAppropiateAnimation(targetPositionX, targetPositionY));
        

        StartCoroutine( StartController());

    }

    IEnumerator StartController()
    {
        Debug.Log("start playing anim");
        Debug.Log("Controller start pos: " + controller.transform.position);
        yield return new WaitForSeconds(0.4f);

        moveController = true;
        startTime = Time.time;

        
        
        
        Debug.Log("start moving controller");
    }

  

    private String calculateAppropiateAnimation(float x,float y)
    {
        Debug.Log(x + ", " + y);

        String diveDirection;
        if (x <= 0)
        {
            diveDirection = "Left";
        }
        else
        {
            diveDirection = "Right";
        }
        x = System.Math.Abs(x);


        if (checkForLowCatch(x, y))
        {
            return "lowCatch" + diveDirection;
        }
        if (checkForShortDive(x, y))
        {
            return "shortDive" + diveDirection;
        }

        if (x < 1.3)
        {
            return "highCatch" + diveDirection;
        }

        
        return "longDive" + diveDirection;
    }

    private bool checkForLowCatch(float x,float y)
    {
        if (x < 1 && y < 6.2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool checkForShortDive(float x,float y)
    {
        if (x<1.5 && y<6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void FixedUpdate()
    {

    }
    
}
