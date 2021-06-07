using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    private Transform limitador;

    public Vector2 rangoH = Vector2.zero;
    public Vector2 rangoV = Vector2.zero;


    void LateUpdate()
    {
        limitador.position = new Vector3(
            Mathf.Clamp(transform.position.x, rangoV.x, rangoV.y),
            Mathf.Clamp(transform.position.y, rangoH.x, rangoH.y),
            transform.position.z
        );
    }

    // Start is called before the first frame update
    void Start()
    {
        limitador = GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
