using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentilationMechanic : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject player;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("s");
            rb.AddForce(transform.up, ForceMode.Force);
            
        }
    }
}
