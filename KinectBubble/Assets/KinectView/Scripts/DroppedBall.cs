using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Ball")
        {
            Lives.DroppedBall(1);
            Destroy(other.gameObject);
        }

    }
}
