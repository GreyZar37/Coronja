using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerhealth;
    public int maxhealth;

    private GameManager manager;
 //   public GameObject gameOverScreen;

    public TextMeshProUGUI TmproText;
    void Start()
    {
        playerhealth = maxhealth;

        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    


    public void Update()
    {

        if (playerhealth <= 0)
        {
          //  gameOverScreen.SetActive(true);
            this.gameObject.SetActive(false);
        }
            

        if (playerhealth > maxhealth)
        {
            playerhealth = maxhealth;
        }

        TmproText.text = "Health: " + playerhealth;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            playerhealth--;
            manager.IsDead = true;
            this.gameObject.SetActive(false);
        }
    }

}
