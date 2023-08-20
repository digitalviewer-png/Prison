using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0.5f;
            StartCoroutine(ZaWarudo());
        }
    }
    IEnumerator ZaWarudo()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
    }
}
