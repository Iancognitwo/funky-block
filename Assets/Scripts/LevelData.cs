using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public Vector3[] nw;
    public Vector3[] ns;
    public Vector3[] na;
    public Vector3[] nd;

    public string mp;
    public string bp1;
    public Vector3 fin;

    public LevelData(EditorUI data)
    {
        int i = 1;
        while (i < data.nw.Length + 1)
        {
            nw[i] = data.nw[i];
            i++;
        }
        i = 1;
        while (i < data.ns.Length + 1)
        {
            ns[i] = data.ns[i];
            i++;
        }
        i = 1;
        while (i < data.na.Length + 1)
        {
            na[i] = data.na[i];
            i++;
        }
        i = 1;
        while (i < data.nd.Length + 1)
        {
            nd[i] = data.nd[i];
            i++;
        }
        i = 1;

        mp = data.mp;
        bp1 = data.bp1;
        fin = data.fin;
    }
}
