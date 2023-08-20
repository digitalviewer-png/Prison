using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snipers : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.HealthDamage(2);
        }
    }
}
