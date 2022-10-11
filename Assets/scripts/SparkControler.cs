using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkControler : MonoBehaviour
{   
    public float speed = 10;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
