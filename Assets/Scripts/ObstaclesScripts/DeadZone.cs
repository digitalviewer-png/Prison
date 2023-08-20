using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private PlayerHealth health;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            health.HealthDamage(3);
        }
    }
}
