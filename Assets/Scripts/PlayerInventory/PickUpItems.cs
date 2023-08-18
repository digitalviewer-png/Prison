using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    [SerializeField] private InventorySlots inv;

    public void OnTriggerEnter(Collider weapon)
    {
        if (weapon.gameObject.tag == "Knife")
        {
            inv.Check(1);
        }
        else if (weapon.gameObject.tag == "Dubina")
        {
            inv.Check(2);
        }
    }
}
