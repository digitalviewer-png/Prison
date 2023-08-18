using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlots : MonoBehaviour
{
    [SerializeField] private GameObject image1;
    [SerializeField] private GameObject image2;
    [SerializeField] private GameObject image3;
    [SerializeField] private GameObject weapon1, weapon2, weapon3;
    [SerializeField] private float playerButtons;
    private float weaponNumber;
    private bool weapon1Slot,weapon2Slot,weapon3Slot;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            image1.SetActive(true);
            image2.SetActive(false);
            image3.SetActive(false);
            weaponNumber = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
            weaponNumber = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(true);
            weaponNumber = 3;
        }
        ThrowItem();
        
    }
    public void ThrowItem()
    {
        if(weaponNumber == 1 && Input.GetButtonDown("Fire1")) 
        {
            weapon1.SetActive(false);
            weapon1Slot = false;

        }
        else if (weaponNumber == 2 && Input.GetButtonDown("Fire1"))
        {
            weapon2.SetActive(false);
            weapon2Slot = false;
        }
        else if (weaponNumber == 3 && Input.GetButtonDown("Fire1"))
        {
            weapon3.SetActive(false);
            weapon3Slot = false;
        }
    }

    public void Check()
    {
        if (weapon1Slot == false)
        {
            weapon1.SetActive(true);
            weapon1Slot = true;
        }
    }

}
