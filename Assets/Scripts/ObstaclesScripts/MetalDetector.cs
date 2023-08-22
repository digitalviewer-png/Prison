using System.Collections;
using UnityEngine;

public class MetalDetector : MonoBehaviour
{
    [SerializeField] private InventorySlots inventorySlots;

    [SerializeField] private GameObject tip;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tip.SetActive(true);
            inventorySlots.RemoveItems();
            StartCoroutine(UI());
        }
    }

    public IEnumerator UI()
    {
        yield return new WaitForSeconds(2f);
        tip.SetActive(false);
    }

}
