using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class Pill : BaseGridObject
{
    private void Awake()
    {
        objectType = ObjectType.pill;
        //LevelSystem.levelGrids.Add((int)objectType, gridPosition);
    }
}