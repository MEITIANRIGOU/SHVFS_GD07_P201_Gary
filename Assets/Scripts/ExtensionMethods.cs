using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HackMan;

public static class ExtensionMethods
{
    public static Vector3Int ToVector3(this Vector2Int vector2)
    {
        return new Vector3Int(vector2.x, vector2.y, 0);
    }
    public static Vector2Int ToVector2(this Vector3Int vector3)
    {
        return new Vector2Int(vector3.x, vector3.y);
    }
    public static bool IsWall(this Vector3Int vector3)
    {
        return LevelSystem.level[Mathf.Abs(vector3.y), Mathf.Abs(vector3.x)] == 1;
    }
}
