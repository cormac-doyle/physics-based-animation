using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IdleRoot 
{
    public static RootAnimCurves RootAnimCurves()
    {
        AnimationCurve xMotion = new AnimationCurve(xAnimKeys())
        {
            preWrapMode = WrapMode.Clamp,
            postWrapMode = WrapMode.Clamp
        };

        AnimationCurve yMotion = new AnimationCurve(yAnimKeys())
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

    static Keyframe[] xAnimKeys()
    {
    

        Keyframe[] xMotionKeys = {
            new Keyframe(0.0f,0.00025704064f),
        new Keyframe(0.016666668f,-0.0029971434f),
        new Keyframe(0.13333334f,-0.019185198f),
        new Keyframe(0.23333335f,-0.027738241f),
        new Keyframe(0.33333334f,-0.027437378f),
        new Keyframe(0.48333335f,-0.008228125f),
        new Keyframe(0.53333336f,0.0026131715f),
        new Keyframe(0.65000004f,0.034362823f),
        new Keyframe(0.8000001f,0.07497554f),
        new Keyframe(1.0166668f,0.078016505f),
        new Keyframe(1.1666667f,0.03400922f),
        new Keyframe(1.2500001f,0.0030778938f),
        new Keyframe(1.2666668f,-0.0028972016f),
        new Keyframe(1.3666668f,-0.034530148f),
        new Keyframe(1.45f,-0.05091382f),
        new Keyframe(1.6666667f,-0.04269907f),
        new Keyframe(1.8000001f,-0.0031551453f),
        new Keyframe(1.8166667f,0.0028939615f),
        new Keyframe(2.0500002f,0.0898373f),
        new Keyframe(2.266667f,0.13262102f),
        new Keyframe(2.5000002f,0.13020281f),
        new Keyframe(2.8333335f,0.0788729f),
        new Keyframe(3.0833335f,0.041232344f),
        new Keyframe(3.216667f,0.016275994f),
        new Keyframe(3.3000002f,0.0007579387f),
        new Keyframe(3.4f,-0.014630306f),
        new Keyframe(3.5333335f,-0.03239286f),
        new Keyframe(3.6833336f,-0.049707152f),
        new Keyframe(3.8000002f,-0.050528266f),
        new Keyframe(3.9f,-0.040870257f),
        new Keyframe(4.1333337f,-0.022767717f),
        new Keyframe(4.283334f,-0.0049760984f),
        new Keyframe(4.316667f,-0.0012815793f),
        new Keyframe(4.3333335f,0.00029693235f),
        new Keyframe(4.3500004f,0.0016562403f),
        new Keyframe(4.416667f,0.0048617087f),
        new Keyframe(4.4500003f,0.006242839f),
        new Keyframe(4.5f,0.0071051307f),
        new Keyframe(4.5833335f,0.0020781413f),
        new Keyframe(4.6000004f,0.0010252099f),
        new Keyframe(4.616667f,0.00028775152f),
        };
        return xMotionKeys;
    }

    static Keyframe[] yAnimKeys()
    {
        



        Keyframe[] yMotionKeys = {
            new Keyframe(0.0f,0.8712482f),
            new Keyframe(0.36666667f,0.8607405f),
            new Keyframe(0.8333334f,0.84050137f),
            new Keyframe(1.1666667f,0.8499854f),
            new Keyframe(1.6833334f,0.83510697f),
            new Keyframe(2.1333334f,0.8509297f),
            new Keyframe(2.4f,0.8463119f),
            new Keyframe(2.7f,0.8473733f),
            new Keyframe(2.95f,0.84492856f),
            new Keyframe(3.1833334f,0.8370483f),
            new Keyframe(3.4833336f,0.8531232f),
            new Keyframe(3.7000003f,0.85265815f),
            new Keyframe(4.066667f,0.83981705f),
            new Keyframe(4.3f,0.8525642f),
            new Keyframe(4.533334f,0.86188924f),
            new Keyframe(4.616667f,0.8712602f),
        };
        return yMotionKeys;
    }

    static Keyframe[] zAnimKeys()
    {
        Keyframe[] zMotionKeys = {
            new Keyframe(0.0f,0.11485689f),
            new Keyframe(0.13333334f,0.11544823f),
            new Keyframe(0.23333335f,0.118029505f),
            new Keyframe(0.6833334f,0.114580534f),
            new Keyframe(1.0500001f,0.10713103f),
            new Keyframe(1.3166667f,0.10751417f),
            new Keyframe(1.5500001f,0.10388803f),
            new Keyframe(1.7666668f,0.10008052f),
            new Keyframe(2.0f,0.101044424f),
            new Keyframe(2.1833334f,0.09956774f),
            new Keyframe(2.4f,0.10151858f),
            new Keyframe(2.7166667f,0.10980991f),
            new Keyframe(2.9166667f,0.114655375f),
            new Keyframe(3.2500002f,0.119475745f),
            new Keyframe(3.4333334f,0.116889745f),
            new Keyframe(3.6666667f,0.11370585f),
            new Keyframe(3.8333335f,0.10892541f),
            new Keyframe(4.166667f,0.10522311f),
            new Keyframe(4.3833337f,0.1067625f),
            new Keyframe(4.533334f,0.109660916f),
            new Keyframe(4.616667f,0.11479491f),
         };

        return zMotionKeys;

    }

}
