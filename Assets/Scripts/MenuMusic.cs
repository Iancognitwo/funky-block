using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        audioSource.volume = AppData.globalVolume;
    }
}
