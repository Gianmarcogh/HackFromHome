using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 15F;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //var 
        //if (Input.GetKey("d"))
        //{
            
        //}
        //if (Input.getKey("a")){

        //}

        //if (Input.getKey("space")){

        //        }

        gameObject.transform.Translate(velocidad * Time.deltaTime,0,0);
    }
}
