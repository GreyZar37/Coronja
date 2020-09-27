﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class HealthBarEnemies : MonoBehaviour
{
    public int health;
    public int maxhealth;
    public int scoreValue;

    public GameObject deathSound;
    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
        
        if(health <= 0)
        {
            
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