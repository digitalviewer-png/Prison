
using UnityEngine;

public class VentilationMechanic : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private CharacterController characterController;

    [SerializeField] private float force = 100f;

    public void OnTriggerStay(Collider collision)
    {
        float y = Input.GetAxis("Vertical");
        Vector3 moveUp = transform.up * y;

        if (collision.CompareTag("Player"))
        {
            characterController.Move(moveUp * force * Time.deltaTime);
        }
    }
}
