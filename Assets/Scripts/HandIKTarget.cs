using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandIKTarget : MonoBehaviour
{

    public GameObject soccerBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(soccerBall.transform.position.x, soccerBall.transform.position.y, soccerBall.transform.position.z + 2f);
    }
}
