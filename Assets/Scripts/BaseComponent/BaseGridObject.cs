using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan;

namespace HackMan
{
    public class BaseGridObject : MonoBehaviour
    {
        protected enum ObjectType { pill, wall, hackMan, ghost}
        protected ObjectType objectType;
        public Vector3 gridPosition;
    }
    public class MovementComponent : BaseGridObject
    {
        protected float timer = 0;
        public enum Direction { up, down, left, right };
        public Direction movingDirection;
        public Direction pastDirection;

        public Vector3 targetPosition;

        protected virtual void Update()
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
            }
        }
        protected void ChangeTargetPosition(Direction movingDirection)
        {
            switch (movingDirection)
            {
                case Direction.up:
                    targetPosition = gridPosition + Vector3.up;
                    break;
                case Direction.down:
                    targetPosition = gridPosition + Vector3.down;
                    break;
                case Direction.left:
                    targetPosition = gridPosition + Vector3.left;
                    break;
                case Direction.right:
                    targetPosition = gridPosition + Vector3.right;
                    break;
            }
        }
        protected void Move()
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, timer);
            gridPosition = targetPosition;
        }
    }
}