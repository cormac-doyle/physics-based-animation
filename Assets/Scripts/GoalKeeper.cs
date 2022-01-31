using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public GameObject soccerBall;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootBall(Input.mousePosition.x,Input.mousePosition.y);
            
        }

        LongDiveLeft();
        LongDiveRight();
        ShortDiveLeft();
        ShortDiveRight();
    }

    private void ShootBall(float mousePosX, float mousePosY)
    {
        Vector2 shootVelocities = calcShootVelocities(mousePosX, mousePosY);

        PlayAnimation(-shootVelocities.x);

        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(-shootVelocities.x, shootVelocities.y, -6.5f);
    }

    private Vector2 calcShootVelocities(float mousePosX, float mousePosY)
    {
        float MOUSE_ERROR_X = -15f;
        float MOUSE_ERROR_Y = 15f;

        mousePosX -= MOUSE_ERROR_X;
        mousePosY -= MOUSE_ERROR_Y;

        float postRightX = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("PostRight").transform.position).x;
        float postLeftX = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("PostLeft").transform.position).x;

        float shootingAngleX = mapToRange(mousePosX, postRightX, postLeftX, -2.8f, 2.8f);


        float crossBarPosY = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("CrossBar").transform.position).y;
        float groundPosY = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Ground").transform.position).y;

        float shootingAngleY = mapToRange(mousePosY, groundPosY, crossBarPosY, 5.3f, 7.35f);

        return new Vector2(shootingAngleX, shootingAngleY);
    }

    private float mapToRange(float input, float input_start,float input_end, float output_start, float output_end)
    {
        return (input - input_start) / (input_end - input_start) * (output_end - output_start) + output_start;
    }
    
    private void PlayAnimation(float shootingAngleX)
    {

        this.anim.SetTrigger(calculateAppropiateAnimation(shootingAngleX));

    }

    private String calculateAppropiateAnimation(float shootingAngleX)
    {
        if (shootingAngleX > 1.5f)
        {
            return "longDiveRight";
        }
        else if (shootingAngleX > 0f)
        {
            return "shortDiveRight";
        }
        else if (shootingAngleX < -1.5f)
        {
            return "longDiveLeft" ;
        }
        else if (shootingAngleX < 0f)
        {
            return "shortDiveLeft" ;
        }

        return "";
    }

    private void FixedUpdate()
    {

    }

    private void ShortDiveLeft()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            this.anim.SetTrigger("shortDiveLeft");
            
        }
    }

    private void ShortDiveRight()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            this.anim.SetTrigger("shortDiveRight");
            

        }
    }

    private void LongDiveLeft()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.anim.SetTrigger("longDiveLeft");
            

        }
    }

    private void LongDiveRight()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {

            this.anim.SetTrigger("longDiveRight");

        }
    }

    
}
