using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    private AudioSource audioSource;

    private float audioVol = 1f;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSource.volume = audioVol;
    }

    public void setVolume(float volume)
    {
        audioVol = volume;
    }

}
