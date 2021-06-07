using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public GameObject rasho;
    public float tiempoDisparo;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = tiempoDisparo;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;

        if(cooldown < 0)
        {
            GameObject laser = Instantiate(rasho, transform.position, Quaternion.identity);

            if(transform.localScale.y < 0)
            {
                laser.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 100f), ForceMode2D.Force);
            }
            
            else
            {
                laser.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -100f), ForceMode2D.Force);
            }

            cooldown = tiempoDisparo;
            
        }

        
    }
}
