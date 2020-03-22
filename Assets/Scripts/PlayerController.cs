using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 15f;
    public float salto = 1.0f;

    private Vector2 velocity;
    private Rigidbody2D rg2d;



    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        velocity = GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKey("d"))
        {
            velocity.x = velocidad ;
            
        }

        if (Input.GetKey("a"))
        {
            velocity.x = -velocidad ;
        }

        if (Input.GetKey("w"))
        {
            velocity.y = salto;
        }

       // rg2d.AddForce(velocity * Time.deltaTime);
        gameObject.transform.Translate(velocity * Time.deltaTime);
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
       
        //pega = true;
        //coll.contacts nos devuelve una matriz con los contactos de la colision
        Vector2 reflejado = Vector2.Reflect(velocity, coll.contacts[0].normal);
        //rg2d.velocity = reflejado;
        coll.rigidbody.velocity = reflejado;
    }
}
