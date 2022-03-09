using System;
using UnityEngine;


public static class LongDiveRoot
{

    public static RootAnimCurves RootAnimCurves(float targetX, float targetY)
	{
        AnimationCurve xMotion = new AnimationCurve(xAnimKeys(targetX))
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve yMotion = new AnimationCurve(yAnimKeys(targetY))
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve zMotion = new AnimationCurve(zAnimKeys())
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };


        return new RootAnimCurves(xMotion, yMotion, zMotion);
    }

    static Keyframe[] xAnimKeys(float targetX)
    {
        float deltaTarget = -1.75f - targetX;
        float deltaTime = deltaTarget / 4;

        Keyframe[] xMotionKeys = {
            new Keyframe(0.0f,-0.000566336f),
            new Keyframe(0.016666668f,-0.0046848734f),
            new Keyframe(0.033333335f,-0.008677616f),
            new Keyframe(0.050000004f,-0.0132981045f),
            new Keyframe(0.083333336f,-0.022467349f),
            new Keyframe(0.116666675f,-0.03419516f),
            new Keyframe(0.21666668f,-0.08403428f),
            new Keyframe(0.26666668f,-0.110996194f),
            new Keyframe(0.40000004f,-0.19052769f),
            new Keyframe(0.5666667f,-0.352668f),

            //change the value of these keyframe by deltaTarget
            new Keyframe(1.4166666f ,-2.2655077f - deltaTarget),
            new Keyframe(1.4833333f,-2.3841467f- deltaTarget),
            new Keyframe(1.7f ,-2.6709766f- deltaTarget),
            new Keyframe(1.9166666f ,-2.7526927f- deltaTarget),
            new Keyframe(2.15f,-2.6698003f- deltaTarget),
            new Keyframe(2.3666666f ,-2.4839697f- deltaTarget),
            new Keyframe(2.7166667f ,-2.2311354f- deltaTarget),
            new Keyframe(2.95f ,-2.1240964f- deltaTarget),
            new Keyframe(3.3666666f ,-2.159121f- deltaTarget),
            new Keyframe(3.4333334f ,-2.1579838f- deltaTarget),
        };
        return xMotionKeys;
    }

    static Keyframe[] yAnimKeys(float targetY)
    {

        float deltaTarget = targetY - 5.6f - 0.6f;
        Debug.Log("deltaTargetY" + deltaTarget);

        if (deltaTarget < -0.3f)
        {
            deltaTarget = -0.3f;
        }
        Keyframe[] yMotionKeys = {
            new Keyframe(0.0f,0.8713843f),
            new Keyframe(0.18333334f,0.87865144f),
            new Keyframe(0.36666667f,0.882017f),
            new Keyframe(0.5166667f,0.7710004f),
            new Keyframe(0.6f,0.7587574f),
            new Keyframe(0.7166667f,0.8104111f),
            //change these keyframes for height trajectory
           
            new Keyframe(0.95f,1.1528177f+ deltaTarget),
            new Keyframe(1.0166667f,1.1782308f+ deltaTarget),
            new Keyframe(1.0833334f,1.1426175f+ deltaTarget),
            
            //end of height traj
            new Keyframe(1.4333333f,0.2554124f),
            new Keyframe(1.4833335f,0.2251735f),
            new Keyframe(1.6000001f,0.22811729f),
            new Keyframe(1.7f,0.22108105f),
            new Keyframe(1.8500001f,0.21924546f),
            new Keyframe(1.9833335f,0.19571613f),
            new Keyframe(2.1166668f,0.16602096f),
            new Keyframe(2.1833334f,0.17671578f),
            new Keyframe(2.3833334f,0.24862887f),
            new Keyframe(2.4333334f,0.27423528f),
            new Keyframe(2.4833333f,0.30703562f),
            new Keyframe(2.6166668f,0.4143935f),
            new Keyframe(2.7166667f,0.48592114f),
            new Keyframe(2.8166668f,0.5903662f),
            new Keyframe(2.966667f,0.74761033f),
            new Keyframe(3.15f,0.8718355f),
            new Keyframe(3.3000002f,0.8411015f),
            new Keyframe(3.4f,0.8508375f),
        };
        return yMotionKeys;
    }

    static Keyframe[] zAnimKeys()
    {
        Keyframe[] zMotionKeys = {
            new Keyframe(0.0f,0.11815512f),
            new Keyframe(0.116666675f,0.1559398f),
            new Keyframe(0.26666668f,0.22501776f),
            new Keyframe(0.38333336f,0.2918865f),
            new Keyframe(0.4666667f,0.35818994f),
            new Keyframe(1.4166666f,1.0992892f),
            new Keyframe(1.5166667f,1.1128795f),
            new Keyframe(2.0666666f,1.0828496f),
            new Keyframe(2.4166667f,1.1019281f),
            new Keyframe(2.9166667f,1.1487993f),
            new Keyframe(3.35f,1.188141f),
         };

        return zMotionKeys;

    }
    
    
}
