using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    [SerializeField] private InventorySlots inventory;

    [SerializeField] private DestructionObject destruction;

    public void OnTriggerEnter(Collider weapon)
    {
        if (weapon.CompareTag("Knife"))
        {
            inventory.AddItem(1);
        }
        else if (weapon.CompareTag("Dubina"))
        {
            destruction.DestroyObject();
            inventory.AddItem(2);
        }
        
    }
}
