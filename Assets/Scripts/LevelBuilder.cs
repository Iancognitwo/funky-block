using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelBuilder : MonoBehaviour
{
    public static Vector3[] nw;
    public static Vector3[] ns;
    public static Vector3[] na;
    public static Vector3[] nd;

    public static string mp;
    public static string bp1;
    public static Vector3 winPos;

    public GameObject noteUp;
    public GameObject noteDown;
    public GameObject noteLeft;
    public GameObject noteRight;

    public AudioSource song;
    public SpriteRenderer img1;

    public Vector3 player;

    // Start is called before the first frame update
    void Start()
    {
        LevelData data = SaveCustom.LoadData();

        if (data != null)
        {
            if (data.nw != null)
            {
                int j = 1;
                while (j < data.nw.Length + 1)
                {
                    nw[j] = data.nw[j];
                    j++;
                }
                j = 1;

                int i = 1;
                while (i < nw.Length)
                {
                    Instantiate(noteUp, nw[i], Quaternion.identity);
                    i++;
                }
                i = 1;
            }
            if (data.ns != null)
            {
                int j = 1;
                while (j < data.ns.Length + 1)
                {
                    ns[j] = data.ns[j];
                    j++;
                }
                j = 1;

                int i = 1;
                while (i < ns.Length)
                {
                    Instantiate(noteDown, ns[i], Quaternion.identity);
                    i++;
                }
                i = 1;
            }
            if (data.na != null)
            {
                int j = 1;
                while (j < data.na.Length + 1)
                {
                    na[j] = data.na[j];
                    j++;
                }
                j = 1;

                int i = 1;
                while (i < na.Length)
                {
                    Instantiate(noteLeft, na[i], Quaternion.identity);
                    i++;
                }
                i = 1;
            }
            if (data.nd != null)
            {
                int j = 1;
                while (j < data.nd.Length + 1)
                {
                    nd[j] = data.nd[j];
                    j++;
                }
                j = 1;

                int i = 1;
                while (nd[i] != null)
                {
                    Instantiate(noteRight, nd[i], Quaternion.identity);
                    i++;
                }
            }

            if (data.mp != null)
            {
                mp = data.mp;
                song.clip = Resources.Load<AudioClip>(BuilderUI.path + mp);
            }
            if (data.bp1 != null)
            {
                bp1 = data.bp1;
                img1.sprite = Resources.Load<Sprite>(BuilderUI.path + bp1);
            }

            winPos = new Vector3(1000f, 0f, 0f);
            if (data.fin != null) winPos = data.fin;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
