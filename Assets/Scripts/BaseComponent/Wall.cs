using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class Wall : BaseGridObject
{
    private void Awake()
    {
        objectType = ObjectType.wall;
        LevelSystem.levelGrids.Add((int)objectType, gridPosition);
    }
}