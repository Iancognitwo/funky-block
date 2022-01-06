using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class EditorUI : MonoBehaviour
{
    public TMP_InputField music;
    public TMP_InputField background1;
    public TMP_InputField winPos;

    public TMP_InputField pos;
    public string selected;

    public Vector3[] nw;
    public Vector3[] ns;
    public Vector3[] na;
    public Vector3[] nd;

    public string mp;
    public string bp1;
    public Vector3 fin;

    public GameObject noteUp;
    public GameObject noteDown;
    public GameObject noteLeft;
    public GameObject noteRight;

    public static Vector3 desPos;
    public float finishe;
    // Start is called before the first frame update
    void Start()
    {
        int i = 1;
        while (i < nw.Length + 1)
        {
            nw[i] = LevelBuilder.nw[i];
            i++;
        }
        i = 1;
        while (i < ns.Length + 1)
        {
            ns[i] = LevelBuilder.ns[i];
            i++;
        }
        i = 1;
        while (i < LevelBuilder.na.Length + 1)
        {
            na[i] = LevelBuilder.na[i];
            i++;
        }
        i = 1;
        while (i < LevelBuilder.nd.Length + 1)
        {
            nd[i] = LevelBuilder.nd[i];
            i++;
        }
        i = 1;

        mp = LevelBuilder.mp;
        bp1 = LevelBuilder.bp1;
        fin = LevelBuilder.winPos;

        music.text = mp;
        background1.text = bp1;
        winPos.text = fin.x.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        mp = music.text;
        bp1 = background1.text;

        finishe = 1000f;
        if(string.IsNullOrEmpty(winPos.text) == false) finishe = float.Parse(winPos.text);
        fin = new Vector3(finishe, 0f, 0f);

        SaveCustom.SaveData(this);
    }
    public void SelectUp()
    {
        selected = "up";
    }
    public void SelectDown()
    {
        selected = "down";
    }
    public void SelectLeft()
    {
        selected = "left";
    }
    public void SelectRight()
    {
        selected = "right";
    }
    public void Add()
    {
        Vector3 position;
        float positione;
        positione = float.Parse(pos.text);
        position = new Vector3(positione, 0f, 0f);
        if (selected == "up")
        {
            Instantiate(noteUp, position, Quaternion.identity);
            System.Array.Resize(ref nw, nw.Length + 1);
            nw[nw.Length] = position;
        }
        if (selected == "down")
        {
            Instantiate(noteDown, position, Quaternion.identity);
            System.Array.Resize(ref ns, ns.Length + 1);
            ns[ns.Length] = position;
        }
        if (selected == "left")
        {
            Instantiate(noteLeft, position, Quaternion.identity);
            System.Array.Resize(ref na, na.Length + 1);
            na[na.Length] = position;
        }
        if (selected == "right")
        {
            Instantiate(noteRight, position, Quaternion.identity);
            System.Array.Resize(ref nd, nd.Length + 1);
            nd[nd.Length] = position;
        }
    }
    public void Delete()
    {
        Vector3 position;
        float positione;
        positione = float.Parse(pos.text);
        position = new Vector3(positione, 0f, 0f);

        desPos = position;

        int i = 0;
        while((nw[i] != position) && (i<nw.Length+1))
        {
            i++;
            if(nw[i] == position)
            {
                while(i < nw.Length)
                {
                    nw[i] = nw[i + 1];
                }
                System.Array.Resize(ref nw, i - 1);
            }
            i = 1;
        }
        while ((ns[i] != position) && (i<ns.Length+1))
        {
            i++;
            if (ns[i] == position)
            {
                while (i < ns.Length)
                {
                    ns[i] = ns[i + 1];
                }
                System.Array.Resize(ref ns, i - 1);
            }
            i = 1;
        }
        while ((na[i] != position) && (i<na.Length+1))
        {
            i++;
            if (na[i] == position)
            {
                while (i < na.Length)
                {
                    na[i] = na[i + 1];
                }
                System.Array.Resize(ref na, i - 1);
            }
            i = 1;
        }
        while ((nd[i] != position) && (i<nd.Length+1))
        {
            i++;
            if (nd[i] == position)
            {
                while (i < nd.Length)
                {
                    nd[i] = nd[i + 1];
                }
                System.Array.Resize(ref nd, i - 1);
            }
            i = 1;
        }
        desPos = new Vector3(0f, 1f, 0f);
    }
}
