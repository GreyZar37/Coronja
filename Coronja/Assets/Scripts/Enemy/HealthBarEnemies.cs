using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthBarEnemies : MonoBehaviour
{
    public int health;
    public int maxhealth;
    public int scoreValue;

    
    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
        
        if(health <= 0)
        {
            GameObject.Find("AudioPlayer").GetComponent<AudioSource>().Play();
            
            Destroy(gameObject);
            ScoreManager.score += scoreValue;        
        }
        if(health > maxhealth)
        {
            health = maxhealth;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
            health--;
        }
    }



}
