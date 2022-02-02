using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class ActivateIK : MonoBehaviour
{
    private Rig rig;
    private float rigWeight;
    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rig>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rig.weight = Mathf.Lerp(rig.weight, rigWeight, Time.deltaTime * 0.8f);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigWeight = 1f;
            
        }

        //if(soccer.pos <.z < 1.2)
        //{
          //  rigWeight = 1f;
        //}

    }
}
