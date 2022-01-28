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
        
    }

    // Update is called once per frame
    void Update()
    {
        LongDiveRight();
    }

    private void LongDiveRight()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.anim.SetBool("dive", true);
        }
    }
}
