using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 15f;
    public float salto = 1.0f;

    private Vector2 velocity;

    
    // Start is called before the first frame update
    void Start()
    {
       
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

        gameObject.transform.Translate(velocity * Time.deltaTime);
    }
}
