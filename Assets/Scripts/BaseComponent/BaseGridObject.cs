using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

namespace HackMan
{
    public class BaseGridObject : MonoBehaviour
    {
        public Vector3Int gridPosition;
    }
    public class MovementComponent : BaseGridObject
    {
        protected float progressTarget;

        public Vector3Int movingDirection;
        public Vector3Int pastDirection;

        public Vector3Int targetPosition;

        protected virtual void Update()
        {
            if (transform.position == targetPosition)
            {
                progressTarget = 0;
                gridPosition = targetPosition;
            }
            if (gridPosition == targetPosition && !(gridPosition + movingDirection).IsWall())
            {
                targetPosition += movingDirection;
            }
        }
    }
}