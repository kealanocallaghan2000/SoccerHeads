using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{

    public Rigidbody2D rb;

    Vector3 pushRight;
    Vector3 pushLeft;

    private void Start() {
        pushRight = new Vector3 (0.8f, 0f, 0f);
        pushLeft = new Vector3 (-0.8f, 0f, 0f);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Hit");
            Vector3 direction = (other.transform.position - transform.position).normalized;
            rb.AddForce(-direction * 2.0f, ForceMode2D.Impulse);
            ScoreManager.score += 1;
            
        }
        else if(other.transform.tag == "Barrier")
        {
            rb.AddForce(pushLeft, ForceMode2D.Impulse);
        }
        else if(other.transform.tag == "Barrier2")
        {
            rb.AddForce(pushRight, ForceMode2D.Impulse);
        }
        else if(other.transform.tag == "Ground")
        {
            Vector3 direction = (other.transform.position - transform.position).normalized;
            rb.AddForce(-direction * 1.4f, ForceMode2D.Impulse);
        }
        else if(other.transform.tag == "Post1")
        {
             rb.AddForce(pushLeft, ForceMode2D.Impulse);
        }
        else if(other.transform.tag == "Post2")
        {
            rb.AddForce(pushRight, ForceMode2D.Impulse);
        }
        
    }
}
