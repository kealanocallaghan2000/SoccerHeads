using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public GameObject[] lives;
    public static int life = 3;

    public bool dropball2 = true;
    public bool dropball3 = true;
    public bool dropball4 = true;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life < 1 && dropball4 == true)
        {
            Destroy(lives[0].gameObject);
            dropball4 = false;
        }
        else if(life < 2 && dropball3 == true)
        {
            Destroy(lives[1].gameObject);
            Ball.instance.DropTheBall();
            dropball3 = false;
        }
        else if(life < 3 && dropball2 == true)
        {
            Destroy(lives[2].gameObject);
            Ball.instance.DropTheBall();
            dropball2 = false;
        }
    }

    public static void DroppedBall(int d)
    {
        life -= d;
    }
}
