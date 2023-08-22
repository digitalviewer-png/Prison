using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private PlayerDeath death;

    [SerializeField] private GameObject heart1, heart2, heart3;
    [SerializeField] private GameObject screenOfHurt;

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
        screenOfHurt.SetActive(true);
        StartCoroutine(HurtScreen());

        if (health == 2)
        {
            heart3.SetActive(false);
        }

        else if (health == 1)
        {
            heart2.SetActive(false);
            if (heart3 != false)
            {
                heart3.SetActive(false);
            }
        }

        else if (health == 0)
        {
            heart1.SetActive(false);
        }

        if (health < 1)
        {
            health = 0;
            death.Death();
        }
    }

    public IEnumerator HurtScreen()
    {
        yield return new WaitForSeconds(0.2f);
        screenOfHurt.SetActive(false);
    }
}
