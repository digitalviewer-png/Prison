using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour
{
    [SerializeField] private CharacterController controller; 
    [SerializeField] private float _newHeight = 1; 
    
    private Vector3 _newPos; 
    private bool _check = false; 

    void Update()
    {
        _newPos = new Vector3(transform.position.x, transform.position.y + 0.6f, transform.position.z);
        
        if (controller.isGrounded && Input.GetKeyDown(KeyCode.LeftControl))
        
        {
            if (!_check) 
            {
                On(); 
            }
            else if (_check) 
            {
                Off(); 
            }
        }
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            if (_check) 
            {
                Off();
            }
        }
    }

    void On() 
    {
        _check = true; 
        controller.height = _newHeight;
        
    }

    void Off() 
    {
        _check = false;
        controller.height += 0.72f; 
        transform.position = _newPos;  
    }
}
