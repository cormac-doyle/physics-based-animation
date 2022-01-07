using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    public RagDollController ragDollController;
    // Start is called before the first frame update
    void Start()
    {
        ragDollController = GameObject.FindObjectOfType<RagDollController>().GetComponent<RagDollController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ragDollController.isGrounded = true;
    }

}
