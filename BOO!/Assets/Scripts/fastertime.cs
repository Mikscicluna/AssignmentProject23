using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fastertime : MonoBehaviour
{


    public NavMeshAgent Enemy;
    
    public float EnemyDistanceRun = 4.0f;

    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);

        

        if(distance < EnemyDistanceRun)
        {
            Vector3 dirToEnemy = transform.position - Enemy.transform.position;

            Vector3 newPos = transform.position - dirToEnemy;

            Enemy.SetDestination(newPos);
        }
    }



}
