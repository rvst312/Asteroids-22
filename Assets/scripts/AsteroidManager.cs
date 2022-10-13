using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{   
    public int asteroides_min = 2;
    public int asteroides_max = 8;
    public float limitX = 10;
    public float limitY = 6;
    public GameObject asteroide;
    // Start is called before the first frame update
    void Start()
    {
       int asteroides = Random.Range(asteroides_min, asteroides_max);

       for (int i = 0; i< asteroides; i++)
       {
          Debug.Log("Instanciando asteroide: " + i);
          Vector3 posicion = new Vector3(Random.Range(-limitX, limitX), Random.Range(-limitY, limitY));
          Vector3 rotacion = new Vector3(0,0,Random.Range(0f, 360f));
          GameObject temp = Instantiate(asteroide, posicion, Quaternion.Euler(rotacion));
          temp.GetComponent<AsteroidController>().manager = this;
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
