using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject mainCharacter;
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject guard;

    [SerializeField] private Animation doorAnim;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(mainCharacter.transform.position, door.transform.position) <= 2f) 
            {
                doorAnim.Play();
                guard.SetActive(true);
            }
        }
    }
}
