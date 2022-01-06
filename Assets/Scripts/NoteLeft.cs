using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteLeft : MonoBehaviour
{
    public GameObject green;
    public GameObject red;
    public bool detect = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats player = collision.GetComponent<PlayerStats>();
        player.canLeft = true;
        detect = false;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        PlayerStats player = collision.GetComponent<PlayerStats>();
        if (player.pressLeft == true)
        {
            detect = true;
            player.canLeft = false;
            player.pressLeft = false;
            Instantiate(green, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (detect == false)
        {
            PlayerStats player = collision.GetComponent<PlayerStats>();
            player.canLeft = false;
            player.pressLeft = false;
            player.TakeDamage();
            Instantiate(red, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
