using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    private bool goal = false;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Time Collision: "+Time.time);
        GameObject hand = GameObject.Find("mixamorig:LeftHand");
        Debug.Log("hand:"+hand.transform.position);

        GameObject foot = GameObject.Find("mixamorig:LeftFoot");
        Debug.Log("foot: "+foot.transform.position);

        
        Debug.Log("ball: " + transform.position);

        if (other.gameObject.name == "GoalLine")
        {
            //Debug.Log("GOAL");
            goal = true;
        }

    }
    public bool getGoalStatus()
    {
        return goal;
    }

    public void setGoalStatusFalse()
    {
        goal = false;
    }
}
