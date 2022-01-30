using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeper : MonoBehaviour
{

    public Animator anim;
    public LayerMask layermask;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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
