using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YogaSharp;

[StructLayout(LayoutKind.Sequential)]
public struct YGSize
{
    public float Width;
    public float Height;

    public static implicit operator YGSize(Vector2 size) => new() { Width = size.X, Height = size.Y };
    public static implicit operator Vector2(YGSize size) => new(size.Width, size.Height);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(YGSize left, YGSize right)
    {
        return left.Width == right.Width && left.Height == right.Height;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(YGSize left, YGSize right)
    {
        return !(left == right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj)
    {
        return obj is YGSize size &&
               Width == size.Width &&
               Height == size.Height;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        return HashCode.Combine(Width, Height);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return $"{Width.ToString("0", CultureInfo.InvariantCulture)}x{Height.ToString("0", CultureInfo.InvariantCulture)}";
    }
}
