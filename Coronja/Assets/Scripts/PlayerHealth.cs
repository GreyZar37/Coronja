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

    public TextMeshProUGUI TmproText;
    void Start()
    {
        playerhealth = maxhealth;
    }


    public void Update()
    {

        if (playerhealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
        if (playerhealth > maxhealth)
        {
            playerhealth = maxhealth;
        }

        TmproText.text = "Health: " + playerhealth;
    }



}
