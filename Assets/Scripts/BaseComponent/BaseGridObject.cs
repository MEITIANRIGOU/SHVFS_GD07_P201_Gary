using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HackMan;

namespace HackMan
{
    public class BaseGridObject : MonoBehaviour
    {
        public Vector2Int gridPosition;
    }
    public class BaseGridMovement : BaseGridObject
    {
        protected enum direction { up, down, left, right };
        protected direction movingDirection;

    }
}