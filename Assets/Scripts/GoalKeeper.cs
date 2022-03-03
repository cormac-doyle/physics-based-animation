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


    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        cam = GameObject.Find("Camera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            resetScene();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            calcBallTargetPos(Input.mousePosition.x,Input.mousePosition.y);
        }

    }

    public void resetScene()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
        gameObject.transform.rotation = new Quaternion(0,0,0,0);

        soccerBall.transform.position = new Vector3(0, 0.11f, 11);
        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(0,0 ,0);
        soccerBall.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        soccerBall.GetComponent<GoalDetection>().setGoalStatusFalse();


        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void calcBallTargetPos(float mousePosX, float mousePosY)
    {

    

        Vector2 shootVelocities = calcShootVelocities(mousePosX, mousePosY);


        shootBall(shootVelocities);
    }

    public void shootBall(Vector2 targetPos)
    {
        Debug.Log(targetPos);
        PlayAnimation(-targetPos.x, targetPos.y);

        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(-targetPos.x, targetPos.y, -10f);

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

        return new Vector2(shootingAngleX, shootingAngleY);
    }

    
    
    private void PlayAnimation(float targetPositionX, float targetPositionY)
    {

        this.anim.SetTrigger(calculateAppropiateAnimation(targetPositionX, targetPositionY));

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
