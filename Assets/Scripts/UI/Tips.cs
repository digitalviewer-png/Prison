using System.Collections;
using UnityEngine;

public class Tips : MonoBehaviour
{
    [SerializeField] private GameObject tip;

    public void Tip()
    {
        tip.SetActive(true);
        StartCoroutine(UI());
    }

    public IEnumerator UI()
    {
        yield return new WaitForSeconds(2f);
        tip.SetActive(false);
    }
}
