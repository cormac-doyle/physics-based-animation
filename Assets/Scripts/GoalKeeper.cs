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
    public GameObject IKtarget;
    //public GameObject controller;
    private AnimationCurve xMotion;
    AnimatorClipInfo[] m_CurrentClipInfo;

    private AnimationCurve yMotion;
    Keyframe[] yMotionKeys = {
        new Keyframe(0.0f,0.8713843f),
        new Keyframe(0.18333334f,0.87865144f),
        new Keyframe(0.36666667f,0.882017f),
        new Keyframe(0.5166667f,0.7710004f),
        new Keyframe(0.6f,0.7587574f),
        new Keyframe(0.7166667f,0.8104111f),
        new Keyframe(0.8166667f,0.90171206f),
        new Keyframe(0.8833334f,0.95734817f),
        new Keyframe(0.95000005f,0.9827611f),
        new Keyframe(1.0833334f,0.88547057f),
        new Keyframe(1.2333333f,0.6266224f),
        new Keyframe(1.3000001f,0.46503177f),
        new Keyframe(1.3333334f,0.3991068f),
        new Keyframe(1.3666668f,0.33902624f),
        new Keyframe(1.4166667f,0.24380608f),
        new Keyframe(1.4333334f,0.23158456f),
        new Keyframe(1.45f,0.22436854f),
        new Keyframe(1.4833335f,0.2251735f),
        new Keyframe(1.6000001f,0.22811729f),
        new Keyframe(1.7f,0.22108105f),
        new Keyframe(1.8500001f,0.21924546f),
        new Keyframe(1.9833335f,0.19571613f),
        new Keyframe(2.1166668f,0.16602096f),
        new Keyframe(2.1833334f,0.17671578f),
        new Keyframe(2.3833334f,0.24862887f),
        new Keyframe(2.4333334f,0.27423528f),
        new Keyframe(2.4833333f,0.30703562f),
        new Keyframe(2.6166668f,0.4143935f),
        new Keyframe(2.7166667f,0.48592114f),
        new Keyframe(2.8166668f,0.5903662f),
        new Keyframe(2.966667f,0.74761033f),
        new Keyframe(3.15f,0.8718355f),
        new Keyframe(3.3000002f,0.8411015f),
        new Keyframe(3.4f,0.8508375f),
    };

    private AnimationCurve zMotion;
    Keyframe[] zMotionKeys = {
        new Keyframe(0.0f,0.11815512f),
        new Keyframe(0.116666675f,0.1559398f),
        new Keyframe(0.26666668f,0.22501776f),
        new Keyframe(0.38333336f,0.2918865f),
        new Keyframe(0.4666667f,0.35818994f),
        new Keyframe(1.4166666f,1.0992892f),
        new Keyframe(1.5166667f,1.1128795f),
        new Keyframe(2.0666666f,1.0828496f),
        new Keyframe(2.4166667f,1.1019281f),
        new Keyframe(2.9166667f,1.1487993f),
        new Keyframe(3.35f,1.188141f),
    };


    int animFrame;
    private float startTime;
    private bool moveController=false;

    float timeTillJump = 0.58f;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        cam = GameObject.Find("Camera").GetComponent<Camera>();

        //Get them_Animator, which you attach to the GameObject you intend to animate.
        
        //Fetch the current Animation clip information for the base layer
        m_CurrentClipInfo = this.anim.GetCurrentAnimatorClipInfo(0);
        //Access the current length of the clip
        Debug.Log(m_CurrentClipInfo[0].clip.length);
        //Access the Animation clip name
        Debug.Log(m_CurrentClipInfo[0].clip.name);
        //Access the current length of the clip
        



        yMotion = new AnimationCurve(yMotionKeys)
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        zMotion = new AnimationCurve(zMotionKeys)
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

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

        if (moveController)
        {
            /*
            Vector3 relativeBallPos = new Vector3((targetPos.x - 2.2f) * -1, targetPos.y - 5.6f, 0);
            //controller.transform.position = Vector3.Lerp(new Vector3(0, 1, 0), relativeBallPos, (Time.time - startTime) / (0.96f- timeTillJump));
            float slerpTimeFraction = (Time.time - startTime) / ((0.96f - timeTillJump) * 2);
            //slerp = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3((targetPos.x - 2.2f) * -2 , 0, 0), Utilities.InOut(slerpTimeFraction));

            float yPos = ( ((slerp.y-1)) * relativeBallPos.y)+1;
            //controller.transform.position = new Vector3(slerp.x, slerp.y, 0);
            if (slerpTimeFraction >= 0.495f && slerpTimeFraction <= 0.505f)
            {
                
            }
            */
            float deltaTime = Time.time - startTime;
            transform.position = new Vector3(xMotion.Evaluate(deltaTime), yMotion.Evaluate(deltaTime), zMotion.Evaluate(deltaTime));
            //Debug.Log(Time.time - startTime);
        }
        animFrame += 1;
    }


    public void resetScene()
    {
        //transform.position = new Vector3(0, 1, 0);
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        moveController = false;

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(0, 0.871f, 0);
        

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
        foreach (AnimationClip clip in anim.runtimeAnimatorController.animationClips)
        {
            if (clip.name == "MyLongDive")
            {
                Debug.Log(clip.name);
                
            }
        }

        this.anim.SetTrigger(calculateAppropiateAnimation(targetPositionX, targetPositionY));

        moveController = true;
        Debug.Log("targetX: "+targetPositionX);
        Debug.Log("targetY: " + targetPositionY);

        setLongDiveMotionCurves(targetPositionX, targetPositionY);
        
        startTime = Time.time;
        animFrame = 0;
        //StartCoroutine( StartController());

    }

    private void setLongDiveMotionCurves(float targetX, float targetY)
    {
        xMotion = new AnimationCurve(xLongDiveAnimKeys(targetX))
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        yMotion = new AnimationCurve(yLongDiveAnimKeys(targetY))
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };
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

    Keyframe[] xLongDiveAnimKeys(float targetX)
    {
        float deltaTarget = -2.1f - targetX;
        float deltaTime = deltaTarget / 4;
        
        Keyframe[] xMotionKeys = {
            new Keyframe(0.0f,-0.000566336f),
            new Keyframe(0.016666668f,-0.0046848734f),
            new Keyframe(0.033333335f,-0.008677616f),
            new Keyframe(0.050000004f,-0.0132981045f),
            new Keyframe(0.083333336f,-0.022467349f),
            new Keyframe(0.116666675f,-0.03419516f),
            new Keyframe(0.21666668f,-0.08403428f),
            new Keyframe(0.26666668f,-0.110996194f),
            new Keyframe(0.40000004f,-0.19052769f),
            new Keyframe(0.5666667f,-0.352668f),

            //change the value of these keyframe by deltaTarget
            new Keyframe(1.4166666f ,-2.2655077f - deltaTarget),
            new Keyframe(1.4833333f,-2.3841467f- deltaTarget),
            new Keyframe(1.7f ,-2.6709766f- deltaTarget),
            new Keyframe(1.9166666f ,-2.7526927f- deltaTarget),
            new Keyframe(2.15f,-2.6698003f- deltaTarget),
            new Keyframe(2.3666666f ,-2.4839697f- deltaTarget),
            new Keyframe(2.7166667f ,-2.2311354f- deltaTarget),
            new Keyframe(2.95f ,-2.1240964f- deltaTarget),
            new Keyframe(3.3666666f ,-2.159121f- deltaTarget),
            new Keyframe(3.4333334f ,-2.1579838f- deltaTarget),
        };
        return xMotionKeys;
    }

    Keyframe[] yLongDiveAnimKeys(float targetY)
    {

        float deltaTarget = targetY - 5.6f - 0.75f;
        Debug.Log("deltaTargetY"+deltaTarget);

        if (deltaTarget<-0.3f)
        {
            deltaTarget = -0.3f;
        }
        Keyframe[] yMotionKeys = {
            new Keyframe(0.0f,0.8713843f),
            new Keyframe(0.18333334f,0.87865144f),
            new Keyframe(0.36666667f,0.882017f),
            new Keyframe(0.5166667f,0.7710004f),
            new Keyframe(0.6f,0.7587574f),
            new Keyframe(0.7166667f,0.8104111f),
            //change these keyframes for height trajectory
           
            new Keyframe(0.95f,1.1528177f+ deltaTarget),
            new Keyframe(1.0166667f,1.1782308f+ deltaTarget),
            new Keyframe(1.0833334f,1.1426175f+ deltaTarget),
            
            //end of height traj
            new Keyframe(1.4333333f,0.2554124f),
            new Keyframe(1.4833335f,0.2251735f),
            new Keyframe(1.6000001f,0.22811729f),
            new Keyframe(1.7f,0.22108105f),
            new Keyframe(1.8500001f,0.21924546f),
            new Keyframe(1.9833335f,0.19571613f),
            new Keyframe(2.1166668f,0.16602096f),
            new Keyframe(2.1833334f,0.17671578f),
            new Keyframe(2.3833334f,0.24862887f),
            new Keyframe(2.4333334f,0.27423528f),
            new Keyframe(2.4833333f,0.30703562f),
            new Keyframe(2.6166668f,0.4143935f),
            new Keyframe(2.7166667f,0.48592114f),
            new Keyframe(2.8166668f,0.5903662f),
            new Keyframe(2.966667f,0.74761033f),
            new Keyframe(3.15f,0.8718355f),
            new Keyframe(3.3000002f,0.8411015f),
            new Keyframe(3.4f,0.8508375f),
        };
        return yMotionKeys;
    }

}

