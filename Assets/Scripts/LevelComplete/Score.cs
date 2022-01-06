using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public GameObject player;
    public PlayerStats score;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI tmp = gameObject.GetComponent<TextMeshProUGUI>();

        if (score.health == 4) tmp.text = "S";
        else if (score.health == 3) tmp.text = "A";
        else if (score.health == 2) tmp.text = "B";
        else if (score.health == 1) tmp.text = "C";
    }

    // Update is called once per frame
    void Update()
    {
        if (score.health == 4) tmp.text = "S";
        else if (score.health == 3) tmp.text = "A";
        else if (score.health == 2) tmp.text = "B";
        else if (score.health == 1) tmp.text = "C";
    }
}
