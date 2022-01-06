using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    public TextMeshProUGUI tmp1;
    public TextMeshProUGUI tmp2;

    public Button btn1;
    public Button btn2;

    public GameObject ComingSoon;

    public void Start()
    {
        if (AppData.star01 == 4f) tmp1.text = "1S";
        if (AppData.star01 == 3f) tmp1.text = "1A";
        if (AppData.star01 == 2f) tmp1.text = "1B";
        if (AppData.star01 == 1f) tmp1.text = "1C";
        if (AppData.unlocked01 == false) btn1.interactable = false;

        if (AppData.star02 == 4f) tmp2.text = "2S";
        if (AppData.star02 == 3f) tmp2.text = "2A";
        if (AppData.star02 == 2f) tmp2.text = "2B";
        if (AppData.star02 == 1f) tmp2.text = "2C";
        if (AppData.unlocked02 == false) btn2.interactable = false;
    }
    public void Load01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Load02()
    {
        StartCoroutine(HolUp());
    }

    IEnumerator HolUp()
    {
        ComingSoon.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        ComingSoon.SetActive(false);
    }
}
