using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] private float velocity = 0.0f;
    [SerializeField] private float acceleration = 0.5f;
    [SerializeField] private float deceleration = 1f;

    [SerializeField] private int velocityHash;

    public void Start()
    {
        velocityHash = Animator.StringToHash("Velocity");
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed && velocity < 0.5f)
        {
            velocity += Time.deltaTime + acceleration;
        }

        if (!forwardPressed && velocity > 0.0f) 
        {
            velocity -= Time.deltaTime + deceleration;
        }

        if (!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat(velocityHash, velocity);
    }
}
