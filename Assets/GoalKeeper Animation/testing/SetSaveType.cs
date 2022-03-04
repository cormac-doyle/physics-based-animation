using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSaveType : MonoBehaviour
{
    [SerializeField] private AnimatorOverrideController[] overrideControllers;
    [SerializeField] private AnimatorOverrider overrider;


    public void Set(int value)
    {
        overrider.setAnimation(overrideControllers[value]);
    }
}
