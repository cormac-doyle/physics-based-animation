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
        configurableJoint = GetComponent<ConfigurableJoint>();

        initalJointRotation = configurableJoint.transform.localRotation;
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
