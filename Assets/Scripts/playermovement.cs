using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Vector3 movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += movementSpeed;
        if (transform.position.x < 10)
        {
            transform.position += movementSpeed;
        }
    }
}
