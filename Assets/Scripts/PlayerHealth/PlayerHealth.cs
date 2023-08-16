using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    public void OnTriggerEnter(Collider enemy)
    {
        HealthDamage(1);
    }
    
    public void HealthDamage(int damage)
    {
        health -= damage;

        if (health < 1)
        {
            health = 0;
            Debug.Log("Death");
        }
    }

}
