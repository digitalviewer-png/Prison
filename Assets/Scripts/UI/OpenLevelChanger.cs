using UnityEngine;

public class OpenLevelChanger : MonoBehaviour
{
    [SerializeField] private GameObject levelChanger;
    [SerializeField] private GameObject mainCharacter;
    [SerializeField] private GameObject button;

    private bool hide = true;

    public void Update()
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
         hide = false;
         levelChanger.SetActive(true);
         Cursor.lockState = CursorLockMode.None;
    }
    public void HideLevelChanger()
    {
         hide = true;
         levelChanger.SetActive(false);
         Cursor.lockState = CursorLockMode.Locked;

    }

}
