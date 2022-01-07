using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{

    public Transform targetLimb;
    ConfigurableJoint configurableJoint;
    public bool mirror;
    // Start is called before the first frame update
    void Start()
    {
        configurableJoint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mirror)
        {
            configurableJoint.targetRotation = targetLimb.rotation;

        }
        else
        {
            configurableJoint.targetRotation = Quaternion.Inverse(targetLimb.rotation);

        }
    }
}
