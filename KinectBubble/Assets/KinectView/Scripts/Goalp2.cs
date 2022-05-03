using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goalp2 : MonoBehaviour
{

    public static int p2Score;
    public Text p2ScoreText;

    private void Start() {
        p2Score = 0;
    }

    private void Update() {
        p2ScoreText.text = "" + p2Score;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Ball")
        {
            Debug.Log("GOAL P1");       
            p2Score += 1;
            Destroy(other.gameObject);
            Ball.instance.DropTheBall();
        }
    }
}
