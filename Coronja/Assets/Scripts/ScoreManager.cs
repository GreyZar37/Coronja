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
    
    public void Start()
    {
        TmproText = GetComponent<TextMeshProUGUI>();
        score = 0;

       
    }
    public void Update()
    {
        TmproText.text = "Score: " + score;
       
    }


}
