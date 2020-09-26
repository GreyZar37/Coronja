using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
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
            Destroy(gameObject);
            ScoreManager.score += scoreValue;        
        }
        if(health > maxhealth)
        {
            health = maxhealth;
        }
        
    }
    


}
