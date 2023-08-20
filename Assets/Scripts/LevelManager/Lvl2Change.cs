using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl2Change : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    public void Start()
    {
        StartCoroutine(LoadAfterTimer());
    }
    private IEnumerator LoadAfterTimer()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(sceneNumber);
    }
}
