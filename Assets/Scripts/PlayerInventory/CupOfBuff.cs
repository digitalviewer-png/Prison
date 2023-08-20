using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupOfBuff : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement.SpeedBuff();
        }
    }
}
