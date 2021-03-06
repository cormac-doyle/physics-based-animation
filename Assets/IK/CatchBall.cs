using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;


public class CatchBall : MonoBehaviour
{
    
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject rigGameObject;
    private Rig rig;
    private bool leftHandCollision = false;
    private bool rightHandCollision = false;

    private bool isCaught = false;
    private float rigWeight;
    // Start is called before the first frame update
    void Start()
    {
        rig = rigGameObject.GetComponent<Rig>();
    }

    // Update is called once per frame
    void Update()
    {
        float zDistanceToBall = transform.position.z - rightHand.transform.position.z;
        if (zDistanceToBall>10f) //check for a reset scene
        {
            isCaught = false;
        }

        if (!isCaught)
        {
            if (zDistanceToBall > 2.5 && zDistanceToBall < 4)
            {
                rigWeight = 0.7f;
                rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 2f);

            }

            if (zDistanceToBall > 0 && zDistanceToBall <= 2.5)
            {
                rigWeight = 1f;
                rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 5f);
            }

            if (zDistanceToBall < 0)
            {
                rigWeight = 0.0f;
                rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 3f);
            }

        }
        else
        {
            rig.weight = Mathf.Lerp(rig.weight, 0.0f, Time.deltaTime * 3f);

        }

    }
    Transform parentHand;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "LeftHandPalm" )
        {

            Debug.Log("Lefthand contact points: " + collision.contacts[0].point);

            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Left Hand Hit");
            leftHandCollision = true;

            if (!rightHandCollision)
            {
                parentHand = rightHand.transform;
            }
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "RightHandPalm")
        {
            Debug.Log("Right Hand Hit");
            Debug.Log("Rightthand contact points: " + collision.contacts[0].point);

            rightHandCollision = true;
            if (!leftHandCollision)
            {
                parentHand = leftHand.transform;
            }
        }

        if (leftHandCollision==true && rightHandCollision == true)
        {
            isCaught = true;
            catchBall();
        }
        if (leftHandCollision == true || rightHandCollision == true)
        {
            isCaught = true;
            
        }

        

    }

    void catchBall()
    {
        //If the GameObject has the same tag as specified, output this message in the console
        Debug.Log("Right Hand Hit");
        transform.SetParent(parentHand);
        //transform.position = new Vector3(0, 0f, 0f);
        transform.rotation = new Quaternion(0, 0, 0, 0);
        //transform.position = rightHand.transform.position;

        //transform.position = new Vector3(rightHand.transform.position.x, rightHand.transform.position.y - 0.2f, rightHand.transform.position.z);

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);


        leftHandCollision = false;
        rightHandCollision = false;

    }
}
