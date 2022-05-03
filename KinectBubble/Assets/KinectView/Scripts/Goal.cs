using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    public static int p1Score;
    public Text p1ScoreText;

    private void Start() {
        p1Score = 0;
    }

    private void Update() {
        p1ScoreText.text = "" + p1Score;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Ball")
        {
            Debug.Log("GOAL P1");       
            p1Score += 1;
            Destroy(other.gameObject);
            Ball.instance.DropTheBall();
        }
    }
}
