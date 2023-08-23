using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseSettings : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenSettings();
        }
    }

    public void OpenSettings()
    {
        settings.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0.1f;
    }

    public void CloseSettings()
    {
        settings.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}
