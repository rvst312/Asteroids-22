using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour

{   public float speed_min;
    public float speed_max;

     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direccion = new Vector2(Random.Range(-1, 1f), Random.Range(-1, 1f));
        direccion = direccion * Random.Range(speed_min, speed_max);
        Debug.Log(direccion);
        rb.AddForce(direccion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
