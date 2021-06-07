using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC1 : MonoBehaviour
{
    /*Variables Movimiento**********************/
    private Rigidbody2D rb;
    public float speed;
    private Vector2 input;
    /****************************************************/

    /*Variables Angulo de la nave************************************/
    float angNave;
    public float rotationNav = 0.4f;
    /************************************************/


    
    /*Variables Balas jugador*****************************************/
    public GameObject balaPrefab;
    GameObject[] balas;
    public int amountBalas;
    public Transform disparador;
    /************************************************/


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        balas = new GameObject[amountBalas];
        for(int i = 0; i< balas.Length; i++)
        {
            balas[i] = (GameObject) Instantiate(balaPrefab);
            balas[i].SetActive(false);
        }
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
        GetRotation();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Disparar(); 
        }
    }

    /*FUNCION ANGULO/ROTACION************************************************/
    void GetRotation()
    {
        Vector2 direccion = new Vector2(-input.x, input.y);
        angNave = Mathf.Atan2(direccion.x, direccion.y) * Mathf.Rad2Deg;

        if(rb.rotation <= -90 && angNave >= 90)
        {
            rb.rotation += 360;
            rb.rotation = Mathf.Lerp(rb.rotation, angNave, rotationNav);
        }

        else if(rb.rotation >= 90 && angNave <= -90)
        {
            rb.rotation -= 360;
            rb.rotation = Mathf.Lerp(rb.rotation, angNave, rotationNav);
        }

        else
        {
            rb.rotation = Mathf.Lerp(rb.rotation, angNave, rotationNav);
        }
    }
    /***************************************************************************/


    /*Funcion disparo************************************************************/
    void Disparar()
    {
        for(int i = 0; i<balas.Length; i++)
        {
            if(!balas[i].activeInHierarchy)
            {
                balas[i].SetActive(true);
                balas[i].transform.position = disparador.position;
                break;
            }
        }
    }
}
