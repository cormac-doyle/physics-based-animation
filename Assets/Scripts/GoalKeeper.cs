using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public struct RootAnimCurves
{

    public AnimationCurve x;
    public AnimationCurve y;
    public AnimationCurve z;

    public RootAnimCurves(AnimationCurve x, AnimationCurve y, AnimationCurve z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }
}
public struct RotationAnimCurves
{
    public AnimationCurve x;
    public AnimationCurve y;
    public AnimationCurve z;
    public AnimationCurve w;

    public RotationAnimCurves(AnimationCurve x, AnimationCurve y, AnimationCurve z, AnimationCurve w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }
}

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public GameObject soccerBall;
    public GameObject Post;
    private GameObject IKtarget;
    private GameObject IKtargetRight;

    //public GameObject controller;

    private RootAnimCurves rootAnimCurves = IdleRoot.RootAnimCurves();
    private RotationAnimCurves rootRotationAnimCurves;


    private float startTime;
    private float idleStartTime;

    private bool applyRootMotion=false;
    private float longDiveTimeTillTakeoff = 0.46f;

    private String currentAnimName = "Idle";

    

    private bool shootBallTrigger=false;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        cam = GameObject.Find("Camera").GetComponent<Camera>();
        IKtarget = GameObject.Find("IKtarget");
        IKtargetRight = GameObject.Find("IKtargetRight");

        //Get them_Animator, which you attach to the GameObject you intend to animate.

        //Fetch the current Animation clip information for the base layer


        idleStartTime = Time.time;
    }


    private Vector2 targetPos = new Vector2(0,0);
    private Vector3 slerp;
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
            resetScene();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootBallTrigger = true;
            
        }

        if (shootBallTrigger)
        {
            calcBallTargetPos(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log("target pos " + targetPos);

            shootBallTrigger = false;
            


        }

        //IKtarget.transform.position = new Vector3(-targetPos.x - 0.2f, targetPos.y - 5f, transform.position.z + 0.1f);
        IKtargetRight.transform.position = new Vector3(soccerBall.transform.position.x, soccerBall.transform.position.y+0.05f, transform.position.z + 0.4f);

        IKtarget.transform.position = new Vector3(soccerBall.transform.position.x, soccerBall.transform.position.y, transform.position.z + 0.4f);

        
        
        
        if (applyRootMotion)
        {
            anim.speed = 1.0f;
            float deltaTime = Time.time - startTime;

            

            if (deltaTime > 0.46f)
            {
                anim.speed = 1f;
            }

           
            
            transform.position = new Vector3(rootAnimCurves.x.Evaluate(deltaTime), rootAnimCurves.y.Evaluate(deltaTime), rootAnimCurves.z.Evaluate(deltaTime));
            if (currentAnimName == "longDiveLeft")
            {
                transform.rotation = new Quaternion(rootRotationAnimCurves.x.Evaluate(deltaTime), rootRotationAnimCurves.y.Evaluate(deltaTime), rootRotationAnimCurves.z.Evaluate(deltaTime), rootRotationAnimCurves.w.Evaluate(deltaTime));

            }
            
            

            //Debugging
            if (soccerBall.transform.position.z<1f && soccerBall.transform.position.z > 0.75f)
            {
                Debug.Log("Actual Target Ball Pos: " + soccerBall.transform.position);
            }
            
        } else //play Idle
        {
            float idleDeltaTime = Time.time - idleStartTime;

            if (idleDeltaTime > 4.61f)
            {
                idleStartTime = 0f;
            }
            //transform.position = new Vector3(rootAnimCurves.x.Evaluate(idleDeltaTime), rootAnimCurves.y.Evaluate(idleDeltaTime), rootAnimCurves.z.Evaluate(idleDeltaTime));
        }
    }


    public void resetScene()
    {
        idleStartTime = Time.time;
        //transform.position = new Vector3(0, 1, 0);
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        applyRootMotion = false;
        
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(0, 0.871f, 0);

        soccerBall.transform.parent = null;
        soccerBall.transform.position = new Vector3(0, 0.11f, 11);
        soccerBall.transform.rotation = new Quaternion(0, 0, 0, 0);

        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(0,0 ,0);
        soccerBall.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        soccerBall.GetComponent<GoalDetection>().setGoalStatusFalse();
        soccerBall.GetComponent<Rigidbody>().isKinematic = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        targetPos = new Vector2(0, 0);


        currentAnimName = "Idle";
        rootAnimCurves = IdleRoot.RootAnimCurves();
    }

    public void calcBallTargetPos(float mousePosX, float mousePosY)
    {

    

        Vector2 shootVelocities = calcShootVelocities(mousePosX, mousePosY);


        shootBall(shootVelocities);

        
    }

    public void shootBall(Vector2 shootTarget)
    {
        //Debug.Log(targetPos);
        PlayAnimation(-shootTarget.x, shootTarget.y);



        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(-shootTarget.x, shootTarget.y, -10f);
        //Debug.Log("TimeShoot: "+Time.time);
        targetPos = shootTarget;
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

        currentAnimName = calculateAppropiateAnimation(targetPositionX, targetPositionY);

        if(currentAnimName == "longDiveLeft")
        {
            rootAnimCurves = LongDiveRoot.RootAnimCurves(targetPositionX, targetPositionY);
            rootRotationAnimCurves = LongDiveRoot.RootRotationAnimCurves(targetPositionX, targetPositionY);
        }

        if (currentAnimName == "highCatchLeft")
        {
            rootAnimCurves = HighCatchRoot.RootAnimCurves(targetPositionX, targetPositionY);

        }

        this.anim.SetTrigger(currentAnimName);

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

