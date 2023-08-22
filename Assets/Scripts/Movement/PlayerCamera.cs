using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float mouseSensetivity = 100f;
    [SerializeField] private float xRotation = 0f;

    [SerializeField] private Transform playerBody;
    [SerializeField] private Transform aimTarget;

    [SerializeField] private Camera cam;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    public void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        xRotation = Mathf.Clamp(xRotation, -75f, 75f);

        playerBody.Rotate(Vector3.up * mouseX);

        Ray desiredTargetRay = cam.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        Vector3 desiredTargetPosition = desiredTargetRay.origin + desiredTargetRay.direction * 2f;

        aimTarget.position = desiredTargetPosition;  
    }

    public void CameraMoveOn()
    {
        cam.cullingMask = ~(1 << LayerMask.NameToLayer("Player"));
    }

    public void CameraMoveOff()
    {
        cam.cullingMask = ~(0 << LayerMask.NameToLayer("Player"));
    }
}
