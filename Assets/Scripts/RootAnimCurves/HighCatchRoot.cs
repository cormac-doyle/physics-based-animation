using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HighCatchRoot
{
    public static RootAnimCurves RootAnimCurves(float targetX, float targetY)
    {
        AnimationCurve xMotion = new AnimationCurve(xAnimKeys(-targetX))
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
        Debug.Log("highCatch TargetX: " + targetX);

        Keyframe[] xMotionKeys = {
            new Keyframe(0.0f,-0.0007544838f),
            new Keyframe(0.016666668f,0.0011013404f),
            new Keyframe(0.033333335f,0.0033118653f),
            new Keyframe(0.050000004f,0.005214272f),
            new Keyframe(0.06666667f,0.006961641f),
            new Keyframe(0.10000001f,0.009272325f),
            new Keyframe(0.116666675f,0.009952653f),
            new Keyframe(0.16666667f,0.011002937f),
            new Keyframe(0.18333334f,0.010482468f),
            new Keyframe(0.21666668f,0.010679905f),
            new Keyframe(0.23333335f,0.01124023f),
            new Keyframe(0.26666668f,0.012165971f),
            new Keyframe(0.3f,0.014643822f),
            new Keyframe(0.3166667f,0.018126141f),
            new Keyframe(0.36666667f,0.030180352f),
            new Keyframe(0.48333335f,0.0693551f),
            
            new Keyframe(1.2333333f,targetX- 0.08f ),
            new Keyframe(1.35f,targetX - 0.04f),
            new Keyframe(1.5000001f,targetX),
            new Keyframe(1.6333333f,targetX- 0.04f),
            new Keyframe(1.7166667f,targetX- 0.08f),
            new Keyframe(2.2833335f,0.09874618f),
            new Keyframe(2.3500001f,0.079831295f),
            new Keyframe(2.4666667f,0.059644487f),
            new Keyframe(2.5666668f,0.049818993f),
            new Keyframe(2.7333336f,0.041412815f),

        };
        return mirrorKeyFrames( xMotionKeys);
    }

    static Keyframe[] yAnimKeys(float targetY)
    {
        Debug.Log("highCatch TargetY: " + targetY);



        Keyframe[] yMotionKeys = {
            new Keyframe(0.0f,0.8729375f),
            new Keyframe(0.21666668f,0.79188734f),
            new Keyframe(0.3f,0.7486548f),
            new Keyframe(0.45000002f,0.8349653f),
            new Keyframe(0.73333335f,1.3457632f),
            new Keyframe(0.8000001f,1.3894956f),
            new Keyframe(0.85f,1.399963f),
            new Keyframe(0.9166667f,1.3807828f),
            new Keyframe(0.96666664f,1.3375988f),
            new Keyframe(1.4f,0.705958f),
            new Keyframe(1.5333334f,0.77316886f),
            new Keyframe(1.7166667f,0.8801613f),
            new Keyframe(1.8833334f,0.827335f),
            new Keyframe(2.0833335f,0.8309466f),
            new Keyframe(2.3666668f,0.8934184f),
            new Keyframe(2.5333335f,0.83467144f),
            new Keyframe(2.7333336f,0.85941476f),
        };
        return yMotionKeys;
    }

    static Keyframe[] zAnimKeys()
    {
        Keyframe[] zMotionKeys = {
            new Keyframe(0.0f,0.11807516f),
            new Keyframe(0.18333334f,0.13442928f),
            new Keyframe(0.26666668f,0.14513221f),
            new Keyframe(0.36666667f,0.16031761f),
            new Keyframe(0.45000002f,0.16990283f),
            new Keyframe(0.5166667f,0.18317771f),
            new Keyframe(0.55f,0.19078708f),
            new Keyframe(0.5833334f,0.2050083f),
            new Keyframe(0.65000004f,0.21856733f),
            new Keyframe(0.73333335f,0.25646174f),
            new Keyframe(0.85f,0.30377585f),
            new Keyframe(1.0f,0.36164904f),
            new Keyframe(1.1333334f,0.40885037f),
            new Keyframe(1.1833334f,0.43032834f),
            new Keyframe(1.3166667f,0.45255485f),
            new Keyframe(1.5166668f,0.463206f),
            new Keyframe(1.7333335f,0.46450484f),
            new Keyframe(1.9833335f,0.4970742f),
            new Keyframe(2.3500001f,0.56950784f),
            new Keyframe(2.5833335f,0.59901303f),
            new Keyframe(2.7333336f,0.6043406f),
         };

        return zMotionKeys;

    }

    static Keyframe[] mirrorKeyFrames(Keyframe[] keyFrames)
    {
        for(int i =0; i<keyFrames.Length; i++)
        {
            keyFrames[i].value *= -1;
        }
        return keyFrames;
    }
}
