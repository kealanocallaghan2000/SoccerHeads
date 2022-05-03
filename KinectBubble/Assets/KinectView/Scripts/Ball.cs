using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject football;
    public GameObject spot;
    public static Ball instance;
    
    private void Awake() 
    {
        instance = this; // makes Ball available globally
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DropTheBall();
    }

    private void Update() {

    }

    public void DropTheBall()
    {
        Instantiate(football, spot.transform);  
    }

    
}
