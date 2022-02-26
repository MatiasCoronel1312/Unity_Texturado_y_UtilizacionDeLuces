using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
  public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
       PersecutionPlayer();
    }

    public float rotationSpeed;

    public float speedEnemy;

    public float distancePlayer;
    private void PersecutionPlayer()
    {
        Vector3 deltaVector = player.position - transform.position;
        Vector3 direction = deltaVector.normalized;

        transform.forward = Vector3.Lerp(transform.forward, direction, rotationSpeed * Time.deltaTime);

        if (deltaVector.magnitude >= distancePlayer) // El enemigo se mueve siempre y cuando no sea menor a la distancia Minima
        {

            transform.position += direction * speedEnemy * Time.deltaTime;

        }
    }
}

    
