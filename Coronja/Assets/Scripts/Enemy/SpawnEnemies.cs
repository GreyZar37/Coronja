using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] Enemy;
    private GameManager Manager;

    public Transform[] Spawnpoints;
    
    

     public float SpawnRate;
     [HideInInspector] public float ConstRate;

     private  int SpawnNum;
    [HideInInspector] public int MaxSpawn;

    private void Awake()
    {
        Manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        ConstRate = SpawnRate;
    }
    void FixedUpdate()
    {
            if(Manager.Enemies.Length < Manager.SpawnLimit )
            {
                SpawnRate -= Time.fixedDeltaTime;

                if (SpawnRate < 0)
                {
                    SpawnRate = ConstRate;
                    Spawn();
                }
            }
    }

    void Spawn()
    {
       int SpawnPointNum = 0;
       int NumperSpawn = Random.Range(1, MaxSpawn);
        int WhatEnemy;

      while(NumperSpawn > 0)
        {
            WhatEnemy = Random.Range(0, 2);
            SpawnPointNum = Random.Range(0, 11);
            Instantiate(Enemy[WhatEnemy], Spawnpoints[SpawnPointNum].position, Quaternion.identity);    
            NumperSpawn--;
        }
        
    }
}
