using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    public void Start()
    {
        music.Play();
    }
}
