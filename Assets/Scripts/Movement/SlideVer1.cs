using System.Collections;
using UnityEngine;

public class SlideVer1 : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float _newHeight = 1;
    [SerializeField] private float speed  = 100f;

    [SerializeField] private CharacterController characterController;

    private Vector3 _newPos;

    private bool _check = false;
    
    public void Update()
    {
        _newPos = new Vector3(transform.position.x, transform.position.y + 0.6f, transform.position.z);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown(KeyCode.LeftControl) && characterController.isGrounded)
        {
            
            if (!_check)
            {
                On();
                characterController.Move(move * speed * Time.deltaTime);
                StartCoroutine(Enumerator());
            }

        }
        
    }
    public void On()
    {
        _check = true;
        characterController.height = _newHeight;

    }

    public void Off()
    {
        _check = false;
        characterController.height += 0.85f;
        transform.position = _newPos;
    }

    IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(1f);
        Off();
    }
}
