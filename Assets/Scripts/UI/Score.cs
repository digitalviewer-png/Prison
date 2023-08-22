using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private GameObject tip;

    private float score;

    public void Start()
    {
        score = PlayerPrefs.GetFloat("score");
        scoreText.text = Convert.ToString(score);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tip.SetActive(true);

            score += 1000f;
            scoreText.text = Convert.ToString(score);

            PlayerPrefs.SetFloat("score", score);
            PlayerPrefs.Save();

            this.gameObject.SetActive(false);
        }
    }
}
