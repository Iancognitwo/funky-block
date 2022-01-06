using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public AudioSource audioControl; 
    public GameObject pauseScreen;
    public PlayerStats player;
    public bool isPaused = false;
    public bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startMusic());
        audioControl.volume = AppData.globalVolume;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.win == false) if (Input.GetButtonDown("Cancel")) isPaused = !isPaused;
        if (isPaused)
        {
            if (isPlaying) audioControl.Pause();
            Time.timeScale = 0f;
            pauseScreen.SetActive(true);
        }
        else if (!isPaused)
        {
            if (isPlaying) audioControl.UnPause();
            Time.timeScale = 1f;
            pauseScreen.SetActive(false);
        }
    }

    IEnumerator startMusic()
    {
        audioControl.Stop();
        yield return new WaitForSeconds(2f);
        isPlaying = true;
        audioControl.Play();
    }
}
