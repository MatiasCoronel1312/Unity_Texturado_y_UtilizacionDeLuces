using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingVar : MonoBehaviour
{
    public Transform player;
    private enum EnemyType
    {
        OnlyLookOut,
        PersecutionPlayer
    }

    [SerializeField] private EnemyType enemyType;
    public float rotationSpeed;

    public float speedEnemy;

    public float distancePlayer;

   
    void Start()
    {

    }
    void Update()
    {
       
        SetEnemyMove(enemyType);
    }

    private void SetEnemyMove (EnemyType enemyType)
    {
        Vector3 deltaVector = player.position - transform.position;
        Vector3 direction = deltaVector.normalized;
        
        switch (enemyType)
        {
            case EnemyType.OnlyLookOut:
                transform.forward = Vector3.Lerp(transform.forward, direction, rotationSpeed * Time.deltaTime);  // Enemigo tipo Solo Vigia
                break;
            case EnemyType.PersecutionPlayer:
                 transform.forward = Vector3.Lerp(transform.forward, direction, rotationSpeed * Time.deltaTime); //Enemigo tipo Perseguidor (con distancia minima)
                 if (deltaVector.magnitude >= distancePlayer) {
                 transform.position += direction * speedEnemy * Time.deltaTime;
                 }
                 break;
            default: 
                break;
        }
        
    }
 
}
