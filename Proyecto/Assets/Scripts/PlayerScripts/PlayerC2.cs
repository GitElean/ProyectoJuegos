using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**********************************************/
/*SCRIPT PARA MOVIMIENTOS BASICOS DEL PLAYER*/
/**********************************************/
public class PlayerC2 : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    private Vector2 input;

    

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        
    }

    private void FixedUpdate()
    {
        rb.velocity = input*speed*Time.deltaTime;

    }

    void OnTriggerEnter2D (Collider2D choque)
    {
         if(choque.gameObject.tag.Equals("Enemy"))
        {
            ContadorVida.healthvalue -= 1;
            if(ContadorVida.healthvalue <= 0)
            {
                Destroy(gameObject);
                
            }

        }
        

         
    }

    

    
}
