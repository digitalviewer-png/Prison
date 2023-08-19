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

    [SerializeField] private ThrowingWeapons throwing;

    private float weaponNumber;
    private bool weapon1Slot = true, weapon2Slot = false, weapon3Slot = false;

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
            if (!weapon1Slot == false)
            {
                throwing.Throw(1);
           }
            weapon1Slot = false;

        }

        else if (weaponNumber == 2 && Input.GetButtonDown("Fire1"))
        {
            weapon2.SetActive(false);
            if (!weapon2Slot == false)
            {
                throwing.Throw(2);
            }
            weapon2Slot = false;
        }

        else if (weaponNumber == 3 && Input.GetButtonDown("Fire1"))
        {
            weapon3.SetActive(false);
            if (!weapon3Slot == false)
            {
                throwing.Throw(2);
            }
            weapon3Slot = false;
        }
    }

    public void AddItem(int number)
    {
        if (weapon1Slot == false && number == 1)
        {
            weapon1.SetActive(true);
            weapon1Slot = true;
        }
        else if (weapon2Slot == false && number == 2)
        {
            weapon2.SetActive(true);
            weapon2Slot = true;
        }
        else if (weapon3Slot == false && number == 2)
        {
            weapon3.SetActive(true);
            weapon3Slot = true;
        }
    }

}
