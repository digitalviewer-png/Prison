using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideVer2 : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] CapsuleCollider collider;

    [SerializeField] private float orginalHeight;
    [SerializeField] private float reducedHeaight;
    [SerializeField] private float slideSpeed = 10f;

    private bool isSliding;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
        {
            Sliding();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GoUp();
        }
    }

    public void Sliding()
    {
        collider.height = reducedHeaight;
        rb.AddForce(transform.forward * slideSpeed, ForceMode.VelocityChange);
    }

    public void GoUp()
    {
        collider.height = orginalHeight;
    }

}   



