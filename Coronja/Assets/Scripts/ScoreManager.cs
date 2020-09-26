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
    public TextMeshProUGUI TmproTextTwo;



    private void Start()
    {
        score = 0;
    }

    public void Update()
    {
        TmproText.text = "Score: " + score;
        TmproTextTwo.text = "Total Score: " + score;
    }

   


}
