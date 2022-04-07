using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class PlayerInputComponent : MovementComponent
{
    private void Awake()
    {
        objectType = ObjectType.hackMan;
        //LevelSystem.levelGrids.Add((int)objectType, gridPosition);
    }
    protected override void Update()
    {
        base.Update();
        PlayerMove();
    }
    void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movingDirection = Direction.up;
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movingDirection = Direction.down;
            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movingDirection = Direction.left;
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movingDirection = Direction.right;
            transform.position += Vector3.right;
        }
    }
}