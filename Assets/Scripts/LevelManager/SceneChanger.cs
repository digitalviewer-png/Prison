using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private int sceneNumber;

    public void OnTriggerEnter(Collider  other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}

