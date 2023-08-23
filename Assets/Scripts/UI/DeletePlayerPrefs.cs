using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerPrefs : MonoBehaviour
{
    [SerializeField] private Score score;
    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        score.UpdateUI();
    }
}
