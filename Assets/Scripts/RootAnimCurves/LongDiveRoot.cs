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

    public static RotationAnimCurves RootRotationAnimCurves(float targetX, float targetY)
    {
        AnimationCurve xRotation = new AnimationCurve(xRotationAnimKeys())
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve yRotation = new AnimationCurve(yRotationAnimKeys())
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve zRotation = new AnimationCurve(zRotationAnimKeys(targetY))
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve wRotation = new AnimationCurve(wRotationAnimKeys())
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        return new RotationAnimCurves(xRotation, yRotation, zRotation, wRotation);
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
        //set max
        if (targetY > 7f)
        {
            targetY = 7f;
        }

        float deltaTarget = targetY - 5.6f - 0.6f;
        Debug.Log("deltaTargetY" + deltaTarget);

        

        //set min
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

    static Keyframe[] zRotationAnimKeys(float targetY)
    {
        Debug.Log("Target Y Z rotation: " + targetY);
        Debug.Log("Target Y Z rotation Normalised: " + (targetY-5.6f));

        float rotateBy = (targetY - 5.6f)/10; 

        Keyframe[] zMotionKeys = {
            new Keyframe(0.0f,0.0042746644f),
            new Keyframe(0.050000004f,0.0065194797f),
            new Keyframe(0.083333336f,0.0056663873f),
            new Keyframe(0.10000001f,0.0052818903f),
            new Keyframe(0.116666675f,0.0045755943f),
            new Keyframe(0.15f,0.0035285898f),
            new Keyframe(0.16666667f,0.0029475205f),
            new Keyframe(0.18333334f,0.003067866f),
            new Keyframe(0.20000002f,0.003878932f),
            new Keyframe(0.21666668f,0.0032774368f),
            new Keyframe(0.23333335f,0.002691839f),
            new Keyframe(0.25f,0.003225482f),
            new Keyframe(0.28333336f,0.0041270633f),
            new Keyframe(0.3f,0.0043100114f),
            new Keyframe(0.3166667f,0.0046692183f),
            new Keyframe(0.33333334f,0.005062476f),
            new Keyframe(0.35000002f,0.0060304212f),
            new Keyframe(0.36666667f,0.0067136865f),
            new Keyframe(0.38333336f,0.0076105352f),
            new Keyframe(0.40000004f,0.010195845f),
            new Keyframe(0.4166667f,0.011689041f),
            new Keyframe(0.43333337f,0.013182178f),
            new Keyframe(0.45000002f,0.016882904f),
            new Keyframe(0.4666667f,0.025253084f),
            new Keyframe(0.48333335f,0.033315506f),
            new Keyframe(0.5f,0.044432078f),
            new Keyframe(0.5166667f,0.05708778f),
            new Keyframe(0.6666667f,0.22076207f),
            //launh angle start
            new Keyframe(0.8833333f,0.4178115f-rotateBy),
            new Keyframe(0.95f,0.43062735f-rotateBy),
            new Keyframe(1.0166667f,0.44252998f-rotateBy),
            new Keyframe(1.1166667f,0.43783104f-rotateBy),
            new Keyframe(1.2333333f,0.42959064f-rotateBy),
            new Keyframe(1.2666667f,0.4431246f-rotateBy),
            new Keyframe(1.2833333f,0.40941662f-rotateBy),
            new Keyframe(1.3f,0.39349192f-rotateBy),
            new Keyframe(1.3166667f,0.3764029f-rotateBy),
            new Keyframe(1.35f,0.39093584f-rotateBy),
            new Keyframe(1.4f,0.43328375f-rotateBy),
            //launch angle end

            new Keyframe(1.4333333f,0.50879204f),
            new Keyframe(1.5f,0.5488869f),
            new Keyframe(1.5333333f,0.5582433f),
            new Keyframe(1.5833334f,0.5687578f),
            new Keyframe(1.65f,0.5801226f),
            new Keyframe(1.7833333f,0.6187718f),
            new Keyframe(1.9166666f,0.6339277f),
            new Keyframe(2.0f,0.63064706f),
            new Keyframe(2.1f,0.5631858f),
            new Keyframe(2.1666667f,0.46693066f),
            new Keyframe(2.3500001f,0.18821228f),
            new Keyframe(2.3833334f,0.14497007f),
            new Keyframe(2.4f,0.12645514f),
            new Keyframe(2.4333334f,0.10692036f),
            new Keyframe(2.4666667f,0.10343189f),
            new Keyframe(2.5333335f,0.07122841f),
            new Keyframe(2.5500002f,0.06035732f),
            new Keyframe(2.5833335f,0.053601827f),
            new Keyframe(2.6000001f,0.055426396f),
            new Keyframe(2.65f,0.051946774f),
            new Keyframe(2.6666667f,0.049692772f),
            new Keyframe(2.6833334f,0.046491656f),
            new Keyframe(2.7f,0.03781782f),
            new Keyframe(2.7166667f,0.030507796f),
            new Keyframe(2.7333336f,0.022791212f),
            new Keyframe(2.7500002f,0.011452124f),
            new Keyframe(2.766667f,0.0029857846f),
            new Keyframe(2.7833335f,-0.004356799f),
            new Keyframe(2.8000002f,-0.007771093f),
            new Keyframe(2.8166668f,-0.008680642f),
            new Keyframe(2.8333335f,-0.00829484f),
            new Keyframe(2.8500001f,-0.006234287f),
            new Keyframe(2.8666668f,-0.005199868f),
            new Keyframe(2.9f,-0.0015294674f),
            new Keyframe(2.9166667f,0.00087122177f),
            new Keyframe(2.9333334f,0.003660466f),
            new Keyframe(2.95f,0.0051012896f),
            new Keyframe(2.966667f,0.01264228f),
            new Keyframe(2.9833336f,0.017473124f),
            new Keyframe(3.016667f,0.027240718f),
            new Keyframe(3.0500002f,0.03299752f),
            new Keyframe(3.0833335f,0.033501852f),
            new Keyframe(3.1000001f,0.031409718f),
            new Keyframe(3.1166668f,0.03086376f),
            new Keyframe(3.1333334f,0.028610917f),
            new Keyframe(3.1666667f,0.025201304f),
            new Keyframe(3.1833334f,0.023666924f),
            new Keyframe(3.216667f,0.021613706f),
            new Keyframe(3.2333336f,0.019700004f),
            new Keyframe(3.2500002f,0.017019363f),
            new Keyframe(3.2833335f,0.012145976f),
            new Keyframe(3.3166668f,0.0067225453f),
            new Keyframe(3.3333335f,0.0042770156f),
            new Keyframe(3.3500001f,0.0020263393f),
            new Keyframe(3.3666668f,0.00044556288f),
            new Keyframe(3.3833334f,-0.0010846737f),
            new Keyframe(3.4f,-0.002599755f),
         };

        return zMotionKeys;

    }
    
    static Keyframe[] yRotationAnimKeys()
    {
        Keyframe[] yMotionKeys = {
            new Keyframe(0.0f,0.02868004f),
            new Keyframe(0.083333336f,0.04025392f),
            new Keyframe(0.116666675f,0.0414811f),
            new Keyframe(0.15f,0.040944178f),
            new Keyframe(0.18333334f,0.041803796f),
            new Keyframe(0.20000002f,0.041935027f),
            new Keyframe(0.25f,0.04384795f),
            new Keyframe(0.28333336f,0.040952597f),
            new Keyframe(0.3f,0.03904524f),
            new Keyframe(0.3166667f,0.035753716f),
            new Keyframe(0.33333334f,0.031562902f),
            new Keyframe(0.35000002f,0.025521863f),
            new Keyframe(0.38333336f,0.011149071f),
            new Keyframe(0.40000004f,0.0014046319f),
            new Keyframe(0.4166667f,-0.00912096f),
            new Keyframe(0.43333337f,-0.01934688f),
            new Keyframe(0.45000002f,-0.029863898f),
            new Keyframe(0.4666667f,-0.03911464f),
            new Keyframe(0.5f,-0.059158783f),
            new Keyframe(0.5166667f,-0.06809201f),
            new Keyframe(0.53333336f,-0.07207321f),
            new Keyframe(0.5833334f,-0.08306487f),
            new Keyframe(0.6f,-0.08740742f),
            new Keyframe(0.6166667f,-0.091133654f),
            new Keyframe(0.65000004f,-0.07904256f),
            new Keyframe(0.6833334f,-0.06275505f),
            new Keyframe(0.7166667f,-0.041610643f),
            new Keyframe(0.73333335f,-0.03382864f),
            new Keyframe(0.75000006f,-0.02564412f),
            new Keyframe(0.7666667f,-0.019651072f),
            new Keyframe(0.78333336f,-0.014777122f),
            new Keyframe(0.8000001f,-0.010891613f),
            new Keyframe(0.8166667f,-0.010870876f),
            new Keyframe(0.8333334f,-0.011943826f),
            new Keyframe(0.85f,-0.012962239f),
            new Keyframe(0.86666673f,-0.016025513f),
            new Keyframe(0.8833334f,-0.01997956f),
            new Keyframe(0.90000004f,-0.027257789f),
            new Keyframe(0.9166667f,-0.03187026f),
            new Keyframe(0.9333334f,-0.037716266f),
            new Keyframe(0.95000005f,-0.044692174f),
            new Keyframe(0.9666667f,-0.049511094f),
            new Keyframe(0.9833334f,-0.054899883f),
            new Keyframe(1.0166668f,-0.06288657f),
            new Keyframe(1.0333334f,-0.07269339f),
            new Keyframe(1.0666667f,-0.08464053f),
            new Keyframe(1.1f,-0.09745766f),
            new Keyframe(1.1500001f,-0.10705794f),
            new Keyframe(1.1666667f,-0.1021837f),
            new Keyframe(1.1833334f,-0.099847555f),
            new Keyframe(1.2f,-0.09153827f),
            new Keyframe(1.2166667f,-0.07924096f),
            new Keyframe(1.2333333f,-0.05982792f),
            new Keyframe(1.2500001f,-0.04143373f),
            new Keyframe(1.2666668f,-0.019535208f),
            new Keyframe(1.2833334f,-0.0035012104f),
            new Keyframe(1.3000001f,-0.024054315f),
            new Keyframe(1.3166667f,0.0027049594f),
            new Keyframe(1.3333334f,-0.0061748847f),
            new Keyframe(1.35f,0.018899526f),
            new Keyframe(1.3666668f,0.046409212f),
            new Keyframe(1.4000001f,0.1283513f),
            new Keyframe(1.4166667f,0.18205246f),
            new Keyframe(1.4333334f,0.24560797f),
            new Keyframe(1.4666667f,0.31884563f),
            new Keyframe(1.5000001f,0.32223886f),
            new Keyframe(1.5333334f,0.33459347f),
            new Keyframe(1.6000001f,0.36295152f),
            new Keyframe(1.6333334f,0.37718284f),
            new Keyframe(1.7166667f,0.37703395f),
            new Keyframe(1.8000001f,0.33277208f),
            new Keyframe(1.8666668f,0.33541203f),
            new Keyframe(2.0333335f,0.31713158f),
            new Keyframe(2.0666668f,0.3179743f),
            new Keyframe(2.1000001f,0.33550864f),
            new Keyframe(2.2f,0.35313094f),
            new Keyframe(2.2833335f,0.32190585f),
            new Keyframe(2.3666668f,0.23829712f),
            new Keyframe(2.4f,0.19308828f),
            new Keyframe(2.5000002f,0.11641154f),
            new Keyframe(2.5333335f,0.06592824f),
            new Keyframe(2.5500002f,0.049006335f),
            new Keyframe(2.5666668f,0.035909206f),
            new Keyframe(2.5833335f,0.033795774f),
            new Keyframe(2.6000001f,0.036054805f),
            new Keyframe(2.6166668f,0.038938038f),
            new Keyframe(2.65f,0.041280326f),
            new Keyframe(2.7f,0.059854604f),
            new Keyframe(2.7333336f,0.08017403f),
            new Keyframe(2.7500002f,0.08740338f),
            new Keyframe(2.766667f,0.095018834f),
            new Keyframe(2.7833335f,0.09793546f),
            new Keyframe(2.8000002f,0.10605801f),
            new Keyframe(2.8166668f,0.11191778f),
            new Keyframe(2.8666668f,0.122853436f),
            new Keyframe(2.9166667f,0.1040584f),
            new Keyframe(2.9333334f,0.09496089f),
            new Keyframe(2.95f,0.08285068f),
            new Keyframe(2.966667f,0.07665843f),
            new Keyframe(3.0333335f,0.04671938f),
            new Keyframe(3.0666668f,0.0391113f),
            new Keyframe(3.0833335f,0.037788626f),
            new Keyframe(3.1833334f,0.03281607f),
            new Keyframe(3.216667f,0.031650178f),
            new Keyframe(3.2500002f,0.025025066f),
            new Keyframe(3.266667f,0.022276172f),
            new Keyframe(3.2833335f,0.01976941f),
            new Keyframe(3.3000002f,0.01813639f),
            new Keyframe(3.3166668f,0.016550677f),
            new Keyframe(3.3333335f,0.015343543f),
            new Keyframe(3.3500001f,0.014135111f),
            new Keyframe(3.3666668f,0.013618011f),
            new Keyframe(3.3833334f,0.013011759f),
            new Keyframe(3.4f,0.012874791f),
         };

        return yMotionKeys;

    }

    static Keyframe[] xRotationAnimKeys()
    {
        Keyframe[] xMotionKeys = {
        new Keyframe(0.0f,0.3026882f),
        new Keyframe(0.13333334f,0.3122788f),
        new Keyframe(0.26666668f,0.3216622f),
        new Keyframe(0.38333336f,0.3695503f),
        new Keyframe(0.5166667f,0.42549962f),
        new Keyframe(0.5833334f,0.4237159f),
        new Keyframe(0.6166667f,0.40928966f),
        new Keyframe(0.6666667f,0.4093687f),
        new Keyframe(0.8000001f,0.35590437f),
        new Keyframe(0.9166667f,0.38766274f),
        new Keyframe(0.9666667f,0.41858268f),
        new Keyframe(1.0166668f,0.4358709f),
        new Keyframe(1.1333334f,0.5231005f),
        new Keyframe(1.2166667f,0.6067554f),
        new Keyframe(1.2666668f,0.59648025f),
        new Keyframe(1.2833334f,0.58720624f),
        new Keyframe(1.3000001f,0.5914784f),
        new Keyframe(1.3166667f,0.587955f),
        new Keyframe(1.3333334f,0.5967525f),
        new Keyframe(1.3666668f,0.54094225f),
        new Keyframe(1.4000001f,0.4691431f),
        new Keyframe(1.45f,0.34030396f),
        new Keyframe(1.5000001f,0.31710774f),
        new Keyframe(1.5500001f,0.29265553f),
        new Keyframe(1.6166668f,0.27308667f),
        new Keyframe(1.6500001f,0.24573015f),
        new Keyframe(1.7166667f,0.21029717f),
        new Keyframe(1.7666668f,0.18491538f),
        new Keyframe(1.7833334f,0.17898577f),
        new Keyframe(1.8333334f,0.15623794f),
        new Keyframe(1.8833334f,0.14141127f),
        new Keyframe(1.9000001f,0.13804138f),
        new Keyframe(1.9166667f,0.139f),
        new Keyframe(1.9333334f,0.13830191f),
        new Keyframe(1.95f,0.14168715f),
        new Keyframe(2.016667f,0.17166772f),
        new Keyframe(2.0666668f,0.23337659f),
        new Keyframe(2.15f,0.34626433f),
        new Keyframe(2.25f,0.43325257f),
        new Keyframe(2.3333335f,0.47220248f),
        new Keyframe(2.5000002f,0.49655876f),
        new Keyframe(2.5500002f,0.49422598f),
        new Keyframe(2.6333334f,0.4280141f),
        new Keyframe(2.7500002f,0.24180044f),
        new Keyframe(2.8000002f,0.19949041f),
        new Keyframe(2.8166668f,0.19957995f),
        new Keyframe(2.8500001f,0.20551693f),
        new Keyframe(2.9166667f,0.22655773f),
        new Keyframe(3.0666668f,0.21484455f),
        new Keyframe(3.1666667f,0.21663804f),
        new Keyframe(3.2500002f,0.21567139f),
        new Keyframe(3.3500001f,0.21449919f),
        new Keyframe(3.4f,0.20572047f),
         };

        return xMotionKeys;

    }

    static Keyframe[] wRotationAnimKeys()
    {
        Keyframe[] wMotionKeys = {
            new Keyframe(0.0f,0.95264846f),
            new Keyframe(0.35000002f,0.93411773f),
            new Keyframe(0.6f,0.8932062f),
            new Keyframe(0.75000006f,0.8610709f),
            new Keyframe(0.9333334f,0.7922888f),
            new Keyframe(1.0666667f,0.7277568f),
            new Keyframe(1.2f,0.6411242f),
            new Keyframe(1.2500001f,0.626633f),
            new Keyframe(1.2833334f,0.6368801f),
            new Keyframe(1.3166667f,0.6722105f),
            new Keyframe(1.3333334f,0.67564714f),
            new Keyframe(1.3666668f,0.7106943f),
            new Keyframe(1.4166667f,0.7406732f),
            new Keyframe(1.4333334f,0.7286635f),
            new Keyframe(1.45f,0.69293904f),
            new Keyframe(1.4833335f,0.65738666f),
            new Keyframe(1.5166668f,0.6561076f),
            new Keyframe(1.5500001f,0.6483646f),
            new Keyframe(1.6000001f,0.63135284f),
            new Keyframe(1.6333334f,0.62793744f),
            new Keyframe(1.7f,0.6270537f),
            new Keyframe(1.8000001f,0.6358123f),
            new Keyframe(1.9333334f,0.6280744f),
            new Keyframe(2.016667f,0.62984085f),
            new Keyframe(2.0666668f,0.6298775f),
            new Keyframe(2.2f,0.6941936f),
            new Keyframe(2.4166667f,0.8479545f),
            new Keyframe(2.6333334f,0.9012592f),
            new Keyframe(2.8166668f,0.9734305f),
            new Keyframe(3.3166668f,0.9757512f),
            new Keyframe(3.4f,0.9785227f),
         };

        return wMotionKeys;

    }


}
