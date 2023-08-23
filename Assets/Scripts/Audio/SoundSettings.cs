using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void ChangeMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, volume));
    }
}