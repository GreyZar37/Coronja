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

    public GameObject gameOverScreen;

    public TextMeshProUGUI TmproText;
    void Start()
    {
        playerhealth = maxhealth;
    }


    public void Update()
    {

        if (playerhealth <= 0)
        {
            gameOverScreen.SetActive(true);
        }
            

        if (playerhealth > maxhealth)
        {
            playerhealth = maxhealth;
        }

        TmproText.text = "Health: " + playerhealth;
        
    }



}
