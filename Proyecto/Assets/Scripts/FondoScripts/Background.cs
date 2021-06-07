using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 InitialPosition;

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime);
        if(transform.position.y < -12.19f)
        {
            transform.position = InitialPosition;
        }
    }
}
