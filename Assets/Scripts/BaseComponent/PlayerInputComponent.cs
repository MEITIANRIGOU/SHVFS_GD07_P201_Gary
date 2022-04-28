using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Pill>() != null)
        {
            Destroy(other.gameObject);
            if (FindObjectsOfType<Pill>().Length == 0)
            {

                SceneManager.LoadScene("Game");
            }
        }
        else if (other.gameObject.GetComponent<EnemyInputComponent>() != null)
        {
            SceneManager.LoadScene("Game");
        }
    }
}