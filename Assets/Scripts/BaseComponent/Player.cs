using HackMan;
using UnityEngine;

public class Player : BaseGridMovement
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movingDirection = direction.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movingDirection = direction.down;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movingDirection = direction.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movingDirection = direction.right;
        }
    }
}