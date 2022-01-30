using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public GameObject soccerBall;
    
    float shootingAngleX;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        shootingAngleX = UnityEngine.Random.Range(-2.8f, 2.8f);
        Invoke("ShootBall",5f);
        Invoke("PlayAnimation", 5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        LongDiveLeft();
        LongDiveRight();
        ShortDiveLeft();
        ShortDiveRight();
    }

    private void ShootBall()
    {
        soccerBall.GetComponent<Rigidbody>().velocity = new Vector3(shootingAngleX, 5, -6);
    }

    private void PlayAnimation()
    {

        this.anim.SetTrigger(calculateAppropiateAnimation());

    }

    private String calculateAppropiateAnimation()
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
