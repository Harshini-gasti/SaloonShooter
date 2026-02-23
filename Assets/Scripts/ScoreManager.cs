using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int count;
    private int score;
    public Text scoreUI;

    void Start()
    {
     
        count = 0;
        score = 0;
    }

    void Update()
    {
        if (count != score)
        {
            Debug.Log(count);
            Debug.Log("Score: " + score);
            score = count;
            scoreUI.text = score.ToString();
        }
    }
}
