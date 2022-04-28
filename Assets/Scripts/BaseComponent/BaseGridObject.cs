using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

namespace HackMan
{
    public class BaseGridObject : MonoBehaviour
    {
        public Vector3 gridPosition;
    }
    public class MovementComponent : BaseGridObject
    {
        public float movementSpeed;

        protected float progressTarget = 1f;

        public Vector3 movingDirection;
        public Vector3 pastDirection;

        public Vector3 targetPosition;

        protected virtual void Start()
        {
            targetPosition = transform.position;
        }

        protected virtual void Update()
        {
            if (transform.position == targetPosition)
            {
                progressTarget = 0f;
                gridPosition = targetPosition;
            }
            if (gridPosition == targetPosition && !(gridPosition + movingDirection).IsWall())
            {
                targetPosition += movingDirection;
                pastDirection = movingDirection;
            }
            else if (gridPosition == targetPosition && !(gridPosition + pastDirection).IsWall())
            {
                targetPosition += pastDirection;
            }

            if (gridPosition == targetPosition) return;
            progressTarget += movementSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, progressTarget);
        }
    }
}