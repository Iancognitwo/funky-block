using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
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

    public float globalVolume;

    public GameData (AppData data)
    {
        u01 = data.u01;
        u02 = data.u02;
        u03 = data.u03;
        u04 = data.u04;
        u05 = data.u05;

        s01 = data.s01;
        s02 = data.s02;
        s03 = data.s03;
        s04 = data.s04;
        s05 = data.s05;

        globalVolume = data.gV;
    }
}
