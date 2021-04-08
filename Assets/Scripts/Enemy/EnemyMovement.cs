using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1;
    NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        EnemyHp enemy = GetComponent<EnemyHp>();
        agent.SetDestination(enemy.manager.ourBase.position);
    }
}
