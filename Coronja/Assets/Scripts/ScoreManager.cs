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
    
    void Awake()
    {
        TmproText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
    void update ()
    {
        TmproText.text = "Score: " + score;
    }


}
