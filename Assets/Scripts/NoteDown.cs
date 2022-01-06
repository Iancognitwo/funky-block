using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDown : MonoBehaviour
{
    public GameObject green;
    public GameObject red;
    public bool detect = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats player = collision.GetComponent<PlayerStats>();
        player.canDown = true;
        detect = false;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        PlayerStats player = collision.GetComponent<PlayerStats>();
        if (player.pressDown == true)
        {
            detect = true;
            player.canDown = false;
            player.pressDown = false;
            Instantiate(green, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (detect == false)
        {
            PlayerStats player = collision.GetComponent<PlayerStats>();
            player.canDown = false;
            player.pressDown = false;
            player.TakeDamage();
            Instantiate(red, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
