using System.Numerics;
using System.Runtime.InteropServices;
namespace YogaSharp;

[StructLayout(LayoutKind.Sequential)]
public struct YGSize
{
    public float width;
    public float height;

    public static implicit operator YGSize(Vector2 size) => new() { width = size.X, height = size.Y };
    public static implicit operator Vector2(YGSize size) => new(size.width, size.height);
}
