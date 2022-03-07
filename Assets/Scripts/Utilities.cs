using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static float mapToRange(float input, float input_start, float input_end, float output_start, float output_end)
    {
        return (input - input_start) / (input_end - input_start) * (output_end - output_start) + output_start;
    }

    public static float InOut(float k)
    {
        if ((k *= 2f) < 1f) return 0.5f * k * k;
        return -0.5f * ((k -= 1f) * (k - 2f) - 1f);
    }





}
