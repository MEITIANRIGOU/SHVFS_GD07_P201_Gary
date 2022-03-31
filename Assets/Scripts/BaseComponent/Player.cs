using HackMan;
using UnityEngine;

public class Player : BaseGridMovement
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movingDirection = direction.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movingDirection = direction.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movingDirection = direction.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movingDirection = direction.right;
        }

        PlayerMove();
    }

    void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}