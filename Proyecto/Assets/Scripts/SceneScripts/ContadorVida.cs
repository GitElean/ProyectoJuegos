using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVida : MonoBehaviour
{
    public static int healthvalue = 15;
    Text health;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + healthvalue;
    }
}
