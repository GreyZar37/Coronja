using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    private TextMeshPro TmproText;
    
    void Awake()
    {
        TmproText = GetComponent<TextMeshPro>();
        score = 0;
    }
    void update ()
    {
        TmproText.text = "Score: " + score;
    }


}
