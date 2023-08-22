using UnityEngine;

public class InventorySlots : MonoBehaviour
{
    [SerializeField] private GameObject imageTracing1;
    [SerializeField] private GameObject imageTracing2;
    [SerializeField] private GameObject imageTracing3;
    [SerializeField] private GameObject weaponForThrowing1, weaponForThrowing2, weaponForThrowing3;

    [SerializeField] private ThrowingWeapons throwing;

    private float weaponNumber;
    private bool weapon1Slot = true, weapon2Slot = false, weapon3Slot = false;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            imageTracing1.SetActive(true);
            imageTracing2.SetActive(false);
            imageTracing3.SetActive(false);
            weaponNumber = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            imageTracing1.SetActive(false);
            imageTracing2.SetActive(true);
            imageTracing3.SetActive(false);
            weaponNumber = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            imageTracing1.SetActive(false);
            imageTracing2.SetActive(false);
            imageTracing3.SetActive(true);
            weaponNumber = 3;
        }
        ThrowItem();
    }

    public void ThrowItem()
    {
        if (weaponNumber == 1 && Input.GetButtonDown("Fire1") && Cursor.lockState == CursorLockMode.Locked)
        {
            weaponForThrowing1.SetActive(false);

            if (!weapon1Slot == false)
            {
                throwing.Throw(1);
            }
            weapon1Slot = false;
        }

        else if (weaponNumber == 2 && Input.GetButtonDown("Fire1") && Cursor.lockState == CursorLockMode.Locked)
        {
            weaponForThrowing2.SetActive(false);

            if (!weapon2Slot == false)
            {
                throwing.Throw(2);
            }
            weapon2Slot = false;
        }

        else if (weaponNumber == 3 && Input.GetButtonDown("Fire1") && Cursor.lockState == CursorLockMode.Locked)
        {
            weaponForThrowing3.SetActive(false);

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
            weaponForThrowing1.SetActive(true);
            weapon1Slot = true;
        }

        else if (weapon2Slot == false && number == 2)
        {
            weaponForThrowing2.SetActive(true);
            weapon2Slot = true;
        }

        else if (weapon3Slot == false && number == 2)
        {
            weaponForThrowing3.SetActive(true);
            weapon3Slot = true;
        }
    }

    public void RemoveItems()
    {
        weaponForThrowing1.SetActive(false); weapon1Slot = false;
        weaponForThrowing2.SetActive(false); weapon2Slot = false;
    }

}
