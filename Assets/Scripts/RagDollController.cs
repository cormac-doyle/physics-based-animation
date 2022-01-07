using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollController : MonoBehaviour
{

    public float speed;
    public float strafeSpeed;
    public float jumpForce;

    public Rigidbody hips;
    public bool isGrounded;
    private bool jump=false;

    

    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent < Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                hips.AddForce(hips.transform.forward * strafeSpeed);
            }
            else
            {
                hips.AddForce(hips.transform.forward * speed);
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            hips.AddForce(hips.transform.right * -speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            hips.AddForce(hips.transform.forward * -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            hips.AddForce(hips.transform.right * speed);
        }
        if (jump)
        {
            if (isGrounded)
            {
                hips.AddForce(new Vector3(0,jumpForce,0));
                isGrounded = false;
                jump = false;
            }
        }
        

    }
}
