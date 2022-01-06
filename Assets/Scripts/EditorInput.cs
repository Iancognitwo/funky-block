using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class EditorInput : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public GameObject player;
    public Music music;
    public GameObject log;
    public bool PlayPause = false;
    public PlayerMovement movement;
    public GameObject song;
    public Image texture;
    public Sprite play;
    public Sprite pause;
    public PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats.health = 5;
        song.SetActive(false);
        movement.moveSpeed = 0f;
        player.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (music.isPaused == false)
        {
            if (Input.GetButtonDown("Up")) tmp.text = tmp.text + "\n" + "Up " + player.transform.position.x;
            if (Input.GetButtonDown("Down")) tmp.text = tmp.text + "\n" + "Down " + player.transform.position.x;
            if (Input.GetButtonDown("Left")) tmp.text = tmp.text + "\n" + "Left " + player.transform.position.x;
            if (Input.GetButtonDown("Right")) tmp.text = tmp.text + "\n" + "Right " + player.transform.position.x;
        }
    }

    public void ScrollUp()
    {
        log.transform.position = new Vector3(log.transform.position.x, log.transform.position.y + 10f);
    }
    public void ScrollDown()
    {
        if (log.transform.position.y > -189) log.transform.position = new Vector3(log.transform.position.x, log.transform.position.y - 10f);
    }
    public void PausePlay()
    {
        if (PlayPause == false)
        {
            texture.sprite = pause;
            movement.moveSpeed = 100f;
            song.SetActive(true);
            PlayPause = true;
        }
        else if(PlayPause == true)
        {
            texture.sprite = play;
            movement.moveSpeed = 0f;
            player.transform.position = new Vector3(0f, 0f, 0f);
            song.SetActive(false);
            PlayPause = false;
        }
    }
}
