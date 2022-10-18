using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float speed = 10;
    public float rotationSpeed = 10;
    public GameObject bala;
    public GameObject boquilla;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            rb.AddForce(transform.up * vertical * speed * Time.deltaTime);
            anim.SetBool("Impulsing", true);
        }
        else
        {
            anim.SetBool("Impulsing", false);
        }

        float horizontal = Input.GetAxis("Horizontal");
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, horizontal * rotationSpeed * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp = Instantiate(bala, boquilla.transform.position, transform.rotation);
            Destroy(temp, 1.5f);
        }
    }
    public void Muerte()
    {
        GameManager.instance.vidas -= 1;
        transform.position = new Vector3(0,0,0);
        rb.velocity = new Vector2(0,0);
        if (GameManager.instance.vidas <= 0)
        {
          Destroy(gameObject); 
          Time.timeScale = 0;  
        }

    }
}


