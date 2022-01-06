using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Complete01 : MonoBehaviour
{
    public GameObject player;
    public GameObject victory;
    public PlayerStats stats;
    public TextMeshProUGUI tmp;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 2010)
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
        if ((stats.health == 4) && (AppData.star01 < 4f)) AppData.star01 = 4f;
        if ((stats.health == 3) && (AppData.star01 < 3f)) AppData.star01 = 3f;
        if ((stats.health == 2) && (AppData.star01 < 2f)) AppData.star01 = 2f;
        if ((stats.health == 1) && (AppData.star01 < 1f)) AppData.star01 = 1f;
        AppData.unlocked02 = true;
        SceneManager.LoadScene("MainMenu");
    }
}
