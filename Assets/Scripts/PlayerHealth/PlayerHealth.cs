using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    public void OnTriggerEnter(Collider enemy)
    {
        health -= 1;

        if (health < 0)
        {
            health = 0;
            Debug.Log("Death");
        }
    }

}
