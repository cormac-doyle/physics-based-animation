using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorOverrider : MonoBehaviour
{
    
    private Animator animator;
    public AnimatorOverrideController overrideController;
    public AnimationClip animClip;

    // Start is called before the first frame update
    void Awake()
    {
        animator.GetComponent<Animator>();

    }
    void Start()
    {

        Debug.Log(overrideController.animationClips);

        animator.runtimeAnimatorController = overrideController;
    }



    public void setAnimation(AnimatorOverrideController overrideController)
    {
        animator.runtimeAnimatorController = overrideController;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            //anim.AddClip(animClip, "LongDive");
            Debug.Log("mouseDown");

           

        }
    }
}
