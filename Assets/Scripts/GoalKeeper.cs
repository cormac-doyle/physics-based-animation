using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public LayerMask layermask;
    public GameObject soccerBall;
    float shootingAngle;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        shootingAngle = 2.9f;
        Invoke("ShootBall",2f);
        Invoke("PlayAnimation", 2f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    private void ShootBall()
    {
        soccerBall.velocity = new Vector3(shootingAngle, 5, -6);
    }

    private void PlayAnimation()
    {

        
        LongDiveRight();
        LongDiveLeft();
        ShortDiveRight();
        ShortDiveLeft();
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
