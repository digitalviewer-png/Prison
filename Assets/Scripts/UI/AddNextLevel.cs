using UnityEngine;

public class AddNextLevel : MonoBehaviour
{
    [SerializeField] private GameObject buttonLevel;

    private int active = 0;

    public void Start()
    {
        active = PlayerPrefs.GetInt("active");

        if (active == 1) 
        {
            buttonLevel.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        buttonLevel.SetActive(true);
        active = 1;
        PlayerPrefs.SetInt("active", active);
    }
}
