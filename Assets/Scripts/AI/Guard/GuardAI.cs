using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private TargetForGuardAI targetForAI;

    [SerializeField] private Animator animator;

    [SerializeField] private PlayerHealth playerHealth;

    [SerializeField] private float lookRadius;

    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance < lookRadius)
        {
            agent.SetDestination(target.position);
            animator.SetBool("TargetInVision", true);

            if (distance + 0.1f <= agent.stoppingDistance) 
            {
                animator.SetBool("TargetInVision", false);
                animator.SetBool("isFighting", true);
                LookTarget();
            }

            if (distance + 0.1f >= agent.stoppingDistance)
            {
                animator.SetBool("TargetInVision", true);
                animator.SetBool("isFighting", false);
            }
        }

        if (distance > lookRadius) 
        {
            Vector3 vector3 = agent.transform.position;
            agent.SetDestination(vector3);
            animator.SetBool("TargetInVision", false);
        }
    }

    public void LookTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.y));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);
    }

    public void OnTriggerEnter(Collider enemyGuard)
    {
        if (enemyGuard.gameObject.tag == "Player") 
        {
            playerHealth.HealthDamage(3);
        }
    }
}
