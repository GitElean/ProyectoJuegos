using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneDestroyer : MonoBehaviour
{ 
    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, 4.5f);
    }

    void OnTriggerEnter2D (Collider2D choque)
    {
         if(choque.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }   

        else if(choque.gameObject.tag.Equals("GoodBullet"))
        {
            ContadorPuntos.scorevalue += 1;           
            Destroy(gameObject);
            Destroy(choque.gameObject);
        }
    }

    
}
