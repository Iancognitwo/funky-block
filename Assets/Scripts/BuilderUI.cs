using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BuilderUI : MonoBehaviour
{
    public TextMeshProUGUI dir;
    public TMP_InputField custom;
    public TextMeshProUGUI type;

    public static string path;
    public static bool mode;

    // Start is called before the first frame update
    void Start()
    {
        dir.text = dir.text + "\n" + Application.persistentDataPath + "/levels";
        mode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle()
    {
        if(mode == true)
        {
            type.text = "PLAYER";
            mode = false;
        }
        else if(mode == false)
        {
            type.text = "EDITOR";
            mode = true;
        }
    }
    public void run()
    {
        if (custom.text != string.Empty)
        {
            path = Application.persistentDataPath + "/levels/" + custom.text;
            if (BuilderUI.mode == true) SceneManager.LoadScene("LevelEditor");
            if (BuilderUI.mode == false) SceneManager.LoadScene("LevelCustom");
            Debug.Log(path);
        }
    }
}
