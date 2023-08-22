using System.Collections;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    
    [SerializeField] private GameObject tip;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tip.SetActive(true);
            playerMovement.SpeedDeBuff();
            StartCoroutine(TipUIOff());
        }
    }

    public IEnumerator TipUIOff()
    {
        yield return new WaitForSeconds(2f);
        tip.SetActive(false);
    }
}
