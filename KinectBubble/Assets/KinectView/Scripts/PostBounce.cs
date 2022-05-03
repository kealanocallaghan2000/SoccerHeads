using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostBounce : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Ball")
        {
            Vector3 direction = (other.transform.position - transform.position).normalized;
            rb.AddForce(-direction * 2.0f, ForceMode2D.Impulse);
        }

    }
}
