using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    private bool goal = false;

    void OnCollisionEnter(Collision other)
    {
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
