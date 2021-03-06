using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HackMan.Scripts;

namespace HackMan
{
    public class LevelSystem : Singleton<LevelSystem>
    {
        public GameObject[] baseGridObjects;

        public static int[,] level = new int[,]
        {
            {1,1,1,1,1,1,1,1,1,1},
            {1,2,0,0,0,0,3,0,0,1},
            {1,0,1,1,0,1,0,0,0,1},
            {1,0,0,1,0,1,1,1,1,1},
            {1,0,1,1,0,0,0,0,0,1},
            {1,0,0,1,0,1,1,1,0,1},
            {1,0,1,1,0,0,0,0,0,1},
            {1,0,0,1,1,0,0,0,3,1},
            {1,0,3,0,1,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1},
        };
        //0:pills 1:wall 2:HackMan 3:Ghost
        protected override void Awake()
        {
            GenerateLevel();
        }
        void GenerateLevel()
        {
            for(int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    transform.position = new Vector3(j, -i, 0);
                    GameObject generatedObject = Instantiate(baseGridObjects[level[i, j]], transform.position, baseGridObjects[level[i, j]].transform.rotation);
                    generatedObject.GetComponent<BaseGridObject>().gridPosition = new Vector3Int(j, -i, 0);
                }
            }
        }
        public int GetCollectionAmount()
        {
            return level.Cast<int>().Count(baseGrid => baseGrid == 0);
        }
    }
}