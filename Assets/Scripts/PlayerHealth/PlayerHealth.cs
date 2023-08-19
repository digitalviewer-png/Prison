using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private PlayerDeath death;

    public void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            HealthDamage(1);
        }
    }
    
    public void HealthDamage(int damage)
    {
        health -= damage;

        if (health < 1)
        {
            health = 0;
            death.Death();
        }
    }

}
