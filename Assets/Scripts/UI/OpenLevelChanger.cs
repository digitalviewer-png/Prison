using UnityEngine;

public class OpenLevelChanger : MonoBehaviour
{
    [SerializeField] private GameObject levelChanger;
    [SerializeField] private GameObject mainCharacter;

    private bool hide = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hide == true)
        {
            if (Vector3.Distance(mainCharacter.transform.position, levelChanger.transform.position) <= 2f)
            {
                ShowLevelChanger();
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.E) && hide == false)
        {
            if (Vector3.Distance(mainCharacter.transform.position, levelChanger.transform.position) <= 2f)
            {
                HideLevelChanger();
            }
        }
    }


    public void ShowLevelChanger()
    {
        if(hide == true) 
        {
            hide = false;
            levelChanger.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

    }
    public void HideLevelChanger()
    {
        if (hide == false)
        {
            hide = true;
            levelChanger.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;

        }

    }

}
