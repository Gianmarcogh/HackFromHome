using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 15F;
    public float salto = 30F;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        var movimiento = 0F;
        var salto = 0F;
        if (Input.GetKey("d"))
        {
            movimiento = velocidad * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            movimiento = -velocidad * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            salto = salto * Time.deltaTime;
        }

        gameObject.transform.Translate(movimiento, salto,0);
    }
}
