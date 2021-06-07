using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawn2 : MonoBehaviour
{

    public GameObject Enemy;
    float rangeX;
    Vector2 ubicacionSpawn;
    public float tiempoSpawn = 2f;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + tiempoSpawn;
            rangeX = Random.Range(-4.57f, 3.74f);
            ubicacionSpawn = new Vector2 (rangeX, transform.position.y);
            Instantiate(Enemy, ubicacionSpawn, Quaternion.identity);
            
        }
    }
}

