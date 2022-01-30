using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{

    public Transform targetLimb;
    ConfigurableJoint configurableJoint;

    Quaternion initalJointRotation;

    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<Rigidbody>().useGravity = false;

        Invoke("Gravity",1f);

        configurableJoint = GetComponent<ConfigurableJoint>();

        initalJointRotation = configurableJoint.transform.localRotation;
    }

    void Gravity()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ConfigurableJointExtensions.SetTargetRotationLocal(configurableJoint, targetLimb.localRotation, initalJointRotation);

    }
}
