using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class Ghost: BaseGridMovement
{
    private void Awake()
    {
        objectType = ObjectType.ghost;
        //LevelSystem.levelGrids.Add((int)objectType, gridPosition);
    }
    protected override void Update()
    {
        base.Update();
        if (timer == 0)
        {
            ChangeTargetPosition(movingDirection);

        }
    }
    void CheckTargetPosition()
    {

    }
}