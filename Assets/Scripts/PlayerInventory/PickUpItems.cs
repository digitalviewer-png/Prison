using System.Collections;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    [SerializeField] private InventorySlots inventory;

    [SerializeField] private DestructionObject destruction;

    [SerializeField] private GameObject tip;

    public void OnTriggerEnter(Collider weapon)
    {
        if (weapon.CompareTag("Knife"))
        {
            inventory.AddItem(1);
        }

        else if (weapon.CompareTag("Dubina"))
        {
            tip.SetActive(true);
            destruction.DestroyObject();
            StartCoroutine(UI());
            inventory.AddItem(2);
        }
        
    }

    public IEnumerator UI()
    {
        yield return new WaitForSeconds(2f);
        tip.SetActive(false);
    }
}
