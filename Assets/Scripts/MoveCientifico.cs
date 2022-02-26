using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCientifico : MonoBehaviour
{
   [SerializeField] float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up*speed*Time.deltaTime*3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down*speed*Time.deltaTime*3);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;;
        }
        if (Input.GetKey(KeyCode.S))
        {
           transform.position -= transform.forward * speed * Time.deltaTime;;
        }
    }
}
