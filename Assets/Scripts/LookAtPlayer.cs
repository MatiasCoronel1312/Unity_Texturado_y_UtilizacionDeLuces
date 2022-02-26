using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform[] player;

    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        MovementLook();
    }

    //public float rotationSpeed;
    public float speedToLook;
    private float newRotation;

    private float LookRotation;

    private void MovementLook()
    {

        Quaternion newRotation =Quaternion.LookRotation((player[0].position - transform.position));
       transform.rotation=Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);

      //  Vector3 deltaVector = player[0].position - transform.position;
      //  Vector3 direction = deltaVector.normalized;

       // transform.forward = Vector3.Lerp(transform.forward, direction, rotationSpeed * Time.deltaTime);
        //transform.position += direction * Time.deltaTime;
    }
}