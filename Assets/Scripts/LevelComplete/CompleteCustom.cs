using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CompleteCustom : MonoBehaviour
{
    public GameObject player;
    public GameObject victory;
    public PlayerStats stats;
    public TextMeshProUGUI tmp;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > LevelBuilder.winPos.x)
        {
            stats.win = true;
            victory.SetActive(true);
        }
        if (stats.health == 4) tmp.text = "S";
        if (stats.health == 3) tmp.text = "A";
        if (stats.health == 2) tmp.text = "B";
        if (stats.health == 1) tmp.text = "C";
    }
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
