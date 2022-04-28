using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

public class EnemyInputComponent: MovementComponent
{
    private readonly Vector3[] _movementDirections = new[]
        {
            Vector3.up,
            Vector3.down,
            Vector3.right,
            Vector3.left,
        };
    protected override void Update()
    {
        if (transform.position == targetPosition)
        {
            var possibleDirections = _movementDirections.Where(movementgDirection =>
            !((targetPosition + movementgDirection).IsWall()) &&
            movementgDirection != -movingDirection).ToList();

            if (possibleDirections.Count < 1)
            {
                possibleDirections.Add(-movingDirection);
            }

            var direction = Random.Range(0, possibleDirections.Count);

            movingDirection = possibleDirections[direction];
        }

        base.Update();
    }
}