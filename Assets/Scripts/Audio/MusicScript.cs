using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    private void Start()
    {
        music.Play();
    }
}
