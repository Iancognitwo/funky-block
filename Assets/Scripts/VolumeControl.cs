using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioSource mixer;
    public Slider volumeSlider;

    public void Start()
    {
        volumeSlider.value = AppData.globalVolume * 10f;
    }
    public void SetVolume(float sliderValue)
    {
        mixer.volume = sliderValue * 0.1f;
        AppData.globalVolume = sliderValue * 0.1f;
    }
}
