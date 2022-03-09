using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public struct RootAnimCurves
{
    //Variable declaration
    //Note: I'm explicitly declaring them as public, but they are public by default. You can use private if you choose.
    public AnimationCurve x;
    public AnimationCurve y;
    public AnimationCurve z;

    //Constructor (not necessary, but helpful)
    public RootAnimCurves(AnimationCurve x, AnimationCurve y, AnimationCurve z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }
}

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public GameObject soccerBall;
    public GameObject Post;
    public GameObject IKtarget;
    //public GameObject controller;

    private RootAnimCurves rootAnimCurves;
   
    private float startTime;
    private bool applyRootMotion=false;


    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        cam = GameObject.Find("Camera").GetComponent<Camera>();

        //Get them_Animator, which you attach to the GameObject you intend to animate.
        
        //Fetch the current Animation clip information for the base layer
     
        

    }

    

    private Vector2 targetPos;
    private Vector3 slerp;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            resetScene();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            targetPos = calcBallTargetPos(Input.mousePosition.x,Input.mousePosition.y);
            Debug.Log("target pos " + targetPos);
            //IKtarget.transform.position = new Vector3(-targetPos.x -0.2f,targetPos.y-5f, transform.position.z + 0.1f);
        }
        IKtarget.transform.position = new Vector3(-targetPos.x - 0.2f, targetPos.y - 5f, transform.position.z + 0.1f);

        if (applyRootMotion)
        {
            float deltaTime = Time.time - startTime;
            transform.position = new Vector3(rootAnimCurves.x.Evaluate(deltaTime), rootAnimCurves.y.Evaluate(deltaTime), rootAnimCurves.z.Evaluate(deltaTime));
            //Debugging
            if(soccerBall.transform.position.z<1f && soccerBall.transform.position.z > 0.75f)
            {
                Debug.Log("Actual Target Ball Pos: " + soccerBall.transform.position);
            }
        }
        
    }


    public void resetScene()
    {
        //transform.position = new Vector3(0, 1, 0);
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        applyRootMotion = false;

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(0, 0.871f, 0);
        

        soccerBall.transform.position = new Vector3(0, 0.11f, 11);
        soccerBall.transform.rotation = new Quaternion(0, 0, 0, 0);

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
        //Debug.Log(targetPos);
        PlayAnimation(-targetPos.x, targetPos.y);



        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(-targetPos.x, targetPos.y, -10f);
        //Debug.Log("TimeShoot: "+Time.time);

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
       // Debug.Log("Predicted Loc:" + new Vector3(shootingAngleX, shootingAngleY, 0));
        


        return new Vector2(shootingAngleX, shootingAngleY);
    }

    
    
    private void PlayAnimation(float targetPositionX, float targetPositionY)
    {

        String animationName = calculateAppropiateAnimation(targetPositionX, targetPositionY);

        if(animationName == "longDiveLeft")
        {
            rootAnimCurves = LongDiveRoot.RootAnimCurves(targetPositionX, targetPositionY);

        }

        if (animationName == "highCatchLeft")
        {
            rootAnimCurves = HighCatchRoot.RootAnimCurves(targetPositionX, targetPositionY);

        }

        this.anim.SetTrigger(animationName);

        applyRootMotion = true;
        Debug.Log("targetX: "+targetPositionX);
        Debug.Log("targetY: " + targetPositionY);

        
        startTime = Time.time;


    }

  


    private String calculateAppropiateAnimation(float x,float y)
    {
        //Debug.Log(x + ", " + y);

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

        if (x < 1.6)
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

