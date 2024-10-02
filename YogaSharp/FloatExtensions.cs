using System;
using System.Runtime.CompilerServices;

namespace YogaSharp;

internal static class FloatExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool IsApproximately(this float a, float b, float margin = 0.001f)
        => MathF.Abs(a - b) < margin;
}
