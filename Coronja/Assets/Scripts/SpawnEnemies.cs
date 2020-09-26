using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnEnemies : MonoBehaviour
{
    public GameObject Enemy;
   
    public Transform[] Spawnpoints;

     public float SpawnRate;
    private float ConstRate;

     private  int SpawnNum;


    private void Awake()
    {
        ConstRate = SpawnRate;
    }
    void FixedUpdate()
    {
        SpawnRate -= Time.fixedDeltaTime;

        if(SpawnRate < 0)
        {
            SpawnRate = ConstRate;
            Spawn();
        }
    }

    void Spawn()
    {
       int SpawnPointNum = Random.Range(0, 13);


        switch (SpawnPointNum)
        {
            case 1:
                Instantiate(Enemy, Spawnpoints[0].position, Quaternion.identity);
                break;
            case 2:
                Instantiate(Enemy, Spawnpoints[1].position, Quaternion.identity);
                break;
            case 3:
                Instantiate(Enemy, Spawnpoints[2].position, Quaternion.identity);
                break;
            case 4:
                Instantiate(Enemy, Spawnpoints[3].position, Quaternion.identity);
                break;
            case 5:
                Instantiate(Enemy, Spawnpoints[4].position, Quaternion.identity);
                break;
            case 6:
                Instantiate(Enemy, Spawnpoints[5].position, Quaternion.identity);
                break;
            case 7:
                Instantiate(Enemy, Spawnpoints[6].position, Quaternion.identity);
                break;
            case 8:
                Instantiate(Enemy, Spawnpoints[7].position, Quaternion.identity);
                break;
            case 9:
                Instantiate(Enemy, Spawnpoints[8].position, Quaternion.identity);
                break;
            case 10:
                Instantiate(Enemy, Spawnpoints[9].position, Quaternion.identity);
                break;
            case 11:
                Instantiate(Enemy, Spawnpoints[10].position, Quaternion.identity);
                break;
            case 12:
                Instantiate(Enemy, Spawnpoints[11].position, Quaternion.identity);
                break;
        }
    }
}
