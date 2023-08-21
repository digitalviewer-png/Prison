using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] private int levelId;

    public void LoadChosenLevel()
    {
        SceneManager.LoadScene(levelId);
    }
}
