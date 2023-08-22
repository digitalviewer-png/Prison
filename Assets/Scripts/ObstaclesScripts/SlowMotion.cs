using System.Collections;
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
    public IEnumerator ZaWarudo()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
    }
}
