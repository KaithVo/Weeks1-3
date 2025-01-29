using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Easings 
{
    /// <summary>
    /// Ease in (Slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Sine Ease In</returns>
    public static float SineIn(float x)
    {
        return x * x;
    }

    /// <summary>
    /// Ease out (Fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Sine Ease Out</returns>
    public static float SineOut(float x)
    {
        return 1 - (1 - x) * (1 - x);
    }

    /// <summary>
    /// Ease in out (Slow then fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Sine Ease In Ease Out</returns>
    public static float SineInOut(float x)
    {
        return -(Mathf.Cos(Mathf.PI * x) - 1) * 0.5f;
    }

    /// <summary>
    /// Ease in (Slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Cubic Ease In</returns>
    public static float CubicIn(float x)
    {
        return x * x * x;
    }

    /// <summary>
    /// Ease out (Fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Cubic Ease Out</returns>
    public static float CubicOut(float x)
    {
        return 1 - Mathf.Pow(1 - x, 3);
    }

    /// <summary>
    /// Ease in out (Slow then fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Cubic Ease In Ease Out</returns>
    public static float CubicInOut(float x)
    {
        return x < 0.5f 
            ? 4 * x * x * x 
            : 1 - Mathf.Pow(-2 * x + 2, 3) * 0.5f;
    }

    /// <summary>
    /// Ease in (Slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Quint Ease In</returns>
    public static float QuintIn(float x)
    {
        return x * x * x * x * x;
    }

    /// <summary>
    /// Ease out (Fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Quint Ease Out</returns>
    public static float QuintOut(float x)
    {
        return 1 - Mathf.Pow(1 - x, 5);
    }

    /// <summary>
    /// Ease in out (Slow then fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Quint Ease In Ease Out</returns>
    public static float QuintInOut(float x)
    {
        return x < 0.5f 
            ? 16 * x * x * x * x * x 
            : 1 - Mathf.Pow(-2 * x + 2, 5) * 0.5f;
    }

    /// <summary>
    /// Ease in (Slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Back Ease In</returns>
    public static float BackIn(float x)
    {
        float c1 = 1.70158f;
        float c3 = c1 + 1;

        return c3 * x * x * x - c1 * x * x;
    }

    /// <summary>
    /// Ease out (Fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Back Ease Out</returns>
    public static float BackOut(float x)
    {
        float c1 = 1.70158f;
        float c3 = c1 + 1;
        return 1 + c3 * Mathf.Pow(x - 1, 3) + c1 * Mathf.Pow(x - 1, 2);
    }

    /// <summary>
    /// Ease in out (Slow then fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Back Ease In Ease Out</returns>
    public static float BackInOut(float x)
    {
        float c1 = 1.70158f;
        float c2 = c1 * 1.525f;

        return x < 0.5
          ? (Mathf.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) * 0.5f
          : (Mathf.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) * 0.5f;
    }

    /// <summary>
    /// Ease in (Slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Circular Ease In</returns>
    public static float CircleIn(float x)
    {
        return 1 - Mathf.Sqrt(1 - Mathf.Pow(x, 2));
    }

    /// <summary>
    /// Ease out (Fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Circular Ease Out</returns>
    public static float CircleOut(float x)
    {
        return Mathf.Sqrt(1 - Mathf.Pow(x - 1, 2));
    }

    /// <summary>
    /// Ease in out (Slow then fast then slow)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Circular Ease In Ease Out</returns>
    public static float CircleInOut(float x)
    {
        return x < 0.5
            ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * x, 2))) * 0.5f
            : (Mathf.Sqrt(1 - Mathf.Pow(-2 * x + 2, 2)) + 1) * 0.5f;
    }

    /// <summary>
    /// Ease Out In (Fast then slow then fast)
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Half Sine Wave. Peaks when X is 0.5</returns>
    public static float HalfSine(float x)
    {
        return Mathf.Sin(x * Mathf.PI);
    }
    /// <summary>
    /// Square Wave
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Half Sine Wave. Peaks when X is inbetween 0.25 and 0.75</returns>
    public static float HalfSquare(float x)
    {
        float c1 = 1.4f;
        return Mathf.Max(Mathf.Min(1, c1 * Mathf.Sin(x * Mathf.PI)));
    }

    /// <summary>
    /// Square Wave
    /// </summary>
    /// <param name="x">The input value from 0 to 1</param>
    /// <returns>Quarter Sine Wave. Peaks when X is inbetween 0.375 and 0.625</returns>
    public static float QuarterSquare(float x)
    {
        float c1 = 1.08f;
        return Mathf.Max(Mathf.Min(1, c1 * Mathf.Sin(x * Mathf.PI)));
    }
}
