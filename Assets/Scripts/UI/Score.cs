using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static TextMeshProUGUI scoreText;
    public static Score instance;
    public static float score;

    public void Awake()
    {
        scoreText = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        DontDestroyOnLoad(transform.gameObject);

    }

    public void OnLevelWasLoaded()
    {
        score += 1000f;
        scoreText.text = Convert.ToString(score);
    }
}
