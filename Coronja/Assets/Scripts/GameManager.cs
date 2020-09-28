using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerHealth playerhp;
    private SpawnEnemies EnemySpawn;

    public GameObject[] Objects;

    [HideInInspector] public GameObject[] Enemies;

    public float ChangeRate;
    private float constChangeRate;

    float DieTimer = 3;
    float ConstTimer = 3;

    [HideInInspector] public bool IsDead;
    [HideInInspector] public int SpawnLimit = 10;

    public bool noSpawn = false;


    private GameObject player;
    private GameObject[] Bullets;
    public GameObject gameOverScreen;
    void Awake()
    {
        constChangeRate = ChangeRate;

        player = GameObject.FindGameObjectWithTag("Player");
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        EnemySpawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnEnemies>();
        EnemySpawn.MaxSpawn = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ChangeRate -= Time.fixedDeltaTime;

        if(IsDead == true)
        {
            GotHit();
        }

        if(ChangeRate < 0 && noSpawn == false)
        {
            ChangeRate = constChangeRate;

            int a = Random.Range(0, 10);
            if(a < 6)
            {
                SpawnLimit += 5;
                EnemySpawn.MaxSpawn++;

                if (SpawnLimit == 30)
                {
                    noSpawn = true;
                }
                Debug.Log(EnemySpawn.MaxSpawn);
                Debug.Log(SpawnLimit);
            }
            EnemySpawn.SpawnRate -= 0.25f;
            EnemySpawn.ConstRate -= 0.25f;
        }
        if (EnemySpawn.ConstRate < 0.5f)
        {
            EnemySpawn.SpawnRate = 0.5f;
            EnemySpawn.ConstRate = 0.5f;
        }

        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Bullets = GameObject.FindGameObjectsWithTag("Bullet");

        if (playerhp.playerhealth <= 0)
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                Objects[i].SetActive(false);
            }
            for (int i = 0; i < Enemies.Length; i++)
            {
                Destroy(Enemies[i]);
            }
            for (int i = 0; i < Bullets.Length; i++)
            {
                Destroy(Bullets[i]);
            }
            gameOverScreen.SetActive(true);
        }
    }

    public void GotHit()
    {
        

        
            DieTimer -= Time.fixedDeltaTime;

                for (int i = 0; i < Objects.Length; i++)
                {
                    Objects[i].SetActive(false);
                }
                for (int i = 0; i < Enemies.Length; i++)
                {
                    Destroy(Enemies[i]);
                }
                for (int i = 0; i < Bullets.Length; i++)
                {
                    Destroy(Bullets[i]);
                }
            
        
         if(DieTimer < 0)
        {
            DieTimer = ConstTimer;
            IsDead = false;
            for (int i = 0; i < Objects.Length; i++)
            {
                player.transform.position = Vector3.zero;
                
                Objects[i].SetActive(true);
            }
        }
       

       

       
    }
}
