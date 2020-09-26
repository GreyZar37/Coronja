using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public TextMeshProUGUI TmproText;
    
    public void start()
    {
        TmproText = GetComponent<TextMeshProUGUI>();
        score = 0;

        Debug.Log(score);
    }
    public void update ()
    {
        TmproText.text = "Score: " + score;
       
    }


}
