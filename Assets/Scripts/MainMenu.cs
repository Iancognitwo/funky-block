using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject main;
    public GameObject levels;
    public GameObject options;

    public GameObject opt;
    public GameObject sellout;
    public GameObject changelog;
    public GameObject credits;
    public GameObject builder;

    public TextMeshProUGUI tmp;

    public void openMain()
    {
        levels.SetActive(false);
        options.SetActive(false);
        main.SetActive(true);
    }
    public void openLevels()
    {
        options.SetActive(false);
        main.SetActive(false);
        levels.SetActive(true);
    }
    public void openOptions()
    {
        main.SetActive(false);
        levels.SetActive(false);
        options.SetActive(true);
        opt.SetActive(true);
        sellout.SetActive(false);
        changelog.SetActive(false);
        credits.SetActive(false);
    }
    public void openSellout()
    {
        sellout.SetActive(true);
        opt.SetActive(false);
    }
    public void openChangelog()
    {
        changelog.SetActive(true);
        opt.SetActive(false);
    }
    public void openCredits()
    {
        credits.SetActive(true);
        opt.SetActive(false);
    }
    public void openBuilder()
    {
        builder.SetActive(true);
        opt.SetActive(false);
    }
    public void openTutorial()
    {
        StartCoroutine(tutorial());
    }

    IEnumerator tutorial()
    {
        tmp.text = "YOU IDIOT!";
        yield return new WaitForSeconds(0.5f);
        tmp.text = "JUST PLAY!";
        yield return new WaitForSeconds(0.5f);
        tmp.text = "USE COMMON SENSE!";
        yield return new WaitForSeconds(0.5f);
        tmp.text = "YOU'LL UNDERSTAND";
        yield return new WaitForSeconds(0.5f);
        tmp.text = "HOW TO PLAY";
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void youtube()
    {
        Application.OpenURL("https://youtube.com/Incognian");
    }
    public void second()
    {
        Application.OpenURL("https://youtube.com/HardCorps2588");
    }
    public void twitch()
    {
        Application.OpenURL("https://twitch.tv/Incognian");
    }
    public void discord()
    {
        Application.OpenURL("https://discord.gg/mUH2nFF");
    }
    public void twitter()
    {
        Application.OpenURL("https://twitter.com/Incognian");
    }
    public void github()
    {
        Application.OpenURL("https://github.com/Iancognitwo/funky-block");
    }
}
