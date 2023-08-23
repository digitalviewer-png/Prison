using UnityEngine;

public class OpenLevelChanger : MonoBehaviour
{
    [SerializeField] private GameObject levelChanger;
    [SerializeField] private GameObject mainCharacter;
    [SerializeField] private GameObject button;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(mainCharacter.transform.position, button.transform.position) <= 2f)
            {
                ShowLevelChanger();
            }
        }
    }

    public void ShowLevelChanger()
    {
        levelChanger.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideLevelChanger()
    {
        levelChanger.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
