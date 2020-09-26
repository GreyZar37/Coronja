using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerHealth playerhp;

    public GameObject[] Objects;

    public GameObject[] Enemies;
    void Awake()
    {
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(playerhp.playerhealth <= 0)
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                Objects[i].SetActive(false);
            }
            for (int i = 0; i < Enemies.Length; i++)
            {
                Destroy(Enemies[i]);
            }
        }
       
           
        
    }
}
