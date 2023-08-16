using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private AIPointSpawn spawn;
    [SerializeField] private float radius;


    public void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(spawn.GetRandomPoint());
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }


}