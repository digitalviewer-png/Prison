using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardDeath : MonoBehaviour
{
    [SerializeField] private GameObject guard;
    [SerializeField] private GameObject ragdoll;


    private Vector3 V3;

    private void Update()
    {
        V3 = guard.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Knife" ||  other.gameObject.tag == "Dubina")
        {
            Death();
        }
    }

    public void Death()
    {
        Vector3 look = guard.transform.forward;
        guard.SetActive(false);
        ragdoll.SetActive(true);
        Instantiate(ragdoll, V3, Quaternion.LookRotation(look));
    }

}
