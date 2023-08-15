using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private float radius;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GetPoint.Instance.GetRandomPoint(transform, radius));
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }


}