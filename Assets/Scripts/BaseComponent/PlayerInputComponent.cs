using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class PlayerInputComponent : MovementComponent
{
    protected override void Update()
    {
        base.Update();
        PlayerMove();
    }
    void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movingDirection = Vector3Int.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movingDirection = Vector3Int.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movingDirection = Vector3Int.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movingDirection = Vector3Int.right;
        }
    }
}