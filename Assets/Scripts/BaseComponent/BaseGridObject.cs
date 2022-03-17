using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGridObject : MonoBehaviour
{
    public IntVector2 gridPosition;
}

public struct IntVector2
{
    public int x;
    public int y;
    public IntVector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}