using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;

        if(Lives.life < 1)
        {
            scoreText.fontSize = 100;
            scoreText.color = Color.red;
            scoreText.text = "Game Over: " + score;
        }
    }
}
