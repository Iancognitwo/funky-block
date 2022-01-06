using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFaces : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0) Destroy(gameObject);
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y);
    }
}
