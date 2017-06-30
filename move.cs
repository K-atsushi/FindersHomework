using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 speed = new Vector3(0f, 0f, 0f);
    // Use this for initialization
    void Start()
    {
        Vector3 speed = new Vector3(0f, 0f, 0f);
        
    }


    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            
            speed.x = 0.5f;
            if (transform.position.x > 5.0f)
            {
                speed.x = 0f;
            }
        }
        if (Input.GetMouseButtonUp(1))
        {
            speed.x = -0.5f;
            if (transform.position.x < -5.0f)
            {
                speed.x = 0f;
            }
        }
       
        transform.Translate(speed.x, 0f, 0f);
        speed.x *= 0.98f;
    }
}




