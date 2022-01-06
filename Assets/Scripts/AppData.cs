using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppData : MonoBehaviour
{
    public static bool unlocked01 = true;
    public static bool unlocked02 = false;
    public static bool unlocked03 = false;
    public static bool unlocked04 = false;
    public static bool unlocked05 = false;

    public static float star01 = 0f;
    public static float star02 = 0f;
    public static float star03 = 0f;
    public static float star04 = 0f;
    public static float star05 = 0f;

    public static float globalVolume = 0.2f;

    public bool u01;
    public bool u02;
    public bool u03;
    public bool u04;
    public bool u05;

    public float s01;
    public float s02;
    public float s03;
    public float s04;
    public float s05;

    public float gV;

    void Update()
    {
        u01 = unlocked01;
        u02 = unlocked02;
        u03 = unlocked03;
        u04 = unlocked04;
        u05 = unlocked05;

        s01 = star01;
        s02 = star02;
        s03 = star03;
        s04 = star04;
        s05 = star05;

        gV = globalVolume;

        SaveSystem.SaveData(this);
    }
}
