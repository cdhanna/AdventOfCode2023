using System.Numerics;

namespace Tests;

public static class Vector2Util
{
    public static Vector2[] GetNeighborsDiag(this Vector2 self)
    {
        return new Vector2[]
        {
            self - Vector2.UnitX + Vector2.Zero,
            self - Vector2.UnitX - Vector2.UnitY,
            self - Vector2.Zero - Vector2.UnitY,
            self + Vector2.UnitX - Vector2.UnitY,
            self + Vector2.UnitX - Vector2.Zero,
            self + Vector2.UnitX + Vector2.UnitY,
            self + Vector2.Zero + Vector2.UnitY,
            self - Vector2.UnitX + Vector2.UnitY,
        };
    }
}