using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    private bool hide = true;

    public void ShowSettings()
    {
        if(hide == true) 
        {
            hide = false;
            settings.SetActive(true);
        }

    }
    public void HideSettings()
    {
        if (hide == false)
        {
            hide = true;
            settings.SetActive(false);
        }

    }

}
