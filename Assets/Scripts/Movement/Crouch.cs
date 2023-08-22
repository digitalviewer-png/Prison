using UnityEngine;

public class Crouch : MonoBehaviour
{
    [SerializeField] private float _newHeight = 1;
    
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerMovement pm;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerCamera playerCamera;

    private bool isCrouching = false;

    private Vector3 _newPos;
    private Vector3 _prevPos;

    public void Update()
    {
        _newPos = new Vector3(0, 1.13f, 0);
        _prevPos = new Vector3(0, 1f, 0);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveWhileCrouching = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown(KeyCode.LeftControl) && characterController.isGrounded)
        {
            if (isCrouching == false)
            {
                animator.SetBool("isCrouching", true);
                isCrouching = true;

                Crouching();
                playerCamera.CameraMoveOn();
            }

            else if (isCrouching == true)
            {
                animator.SetBool("isCrouching", false);

                characterController.height += 0.85f;
                characterController.center = _prevPos;

                isCrouching = false;
                playerCamera.CameraMoveOff();
            }
        }
    }

    public void Crouching()
    {
        characterController.height = _newHeight;

        characterController.center = _newPos;
    }
}
