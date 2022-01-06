using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameData data = SaveSystem.LoadData();

        if (data != null)
        {
            AppData.unlocked01 = data.u01;
            AppData.unlocked02 = data.u02;
            AppData.unlocked03 = data.u03;
            AppData.unlocked04 = data.u04;
            AppData.unlocked05 = data.u05;

            AppData.star01 = data.s01;
            AppData.star02 = data.s02;
            AppData.star03 = data.s03;
            AppData.star04 = data.s04;
            AppData.star05 = data.s05;

            AppData.globalVolume = data.globalVolume;
        }

        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");
    }
}
