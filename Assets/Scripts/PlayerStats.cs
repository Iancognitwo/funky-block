using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Music music;
    public GameObject damaged1;
    public GameObject damaged2;
    public GameObject damaged3;
    public GameObject died;

    public bool canUp;
    public bool canDown;
    public bool canLeft;
    public bool canRight;
    public bool pressUp;
    public bool pressDown;
    public bool pressLeft;
    public bool pressRight;
    public int health;
    public bool win;
    // Start is called before the first frame update
    void Start()
    {
        canUp = false;
        canDown = false;
        canLeft = false;
        canRight = false;
        pressUp = false;
        pressDown = false;
        pressLeft = false;
        pressRight = false;
        health = 4;
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((win == false) && (music.isPaused == false))
        {
            if ((Input.GetButtonDown("Up")) && (canUp == false)) TakeDamage();
            else if ((Input.GetButtonDown("Up")) && (canUp == true))
            {
                pressUp = true;
            }
            if ((Input.GetButtonDown("Down")) && (canDown == false)) TakeDamage();
            else if ((Input.GetButtonDown("Down")) && (canDown == true))
            {
                pressDown = true;
            }
            if ((Input.GetButtonDown("Left")) && (canLeft == false)) TakeDamage();
            else if ((Input.GetButtonDown("Left")) && (canLeft == true))
            {
                pressLeft = true;
            }
            if ((Input.GetButtonDown("Right")) && (canRight == false)) TakeDamage();
            else if ((Input.GetButtonDown("Right")) && (canRight == true))
            {
                pressRight = true;
            }
        }
        /*if (Input.GetButtonDown("Up")) Debug.Log("up" + gameObject.transform.position.x);
        if (Input.GetButtonDown("Down")) Debug.Log("down" + gameObject.transform.position.x);
        if (Input.GetButtonDown("Left")) Debug.Log("left" + gameObject.transform.position.x);
        if (Input.GetButtonDown("Right")) Debug.Log("right" + gameObject.transform.position.x);*/
    }

    public void TakeDamage()
    {
        if(health == 4)
        {
            Instantiate(damaged1, transform.position, Quaternion.identity);
            health--;
        }
        else if (health == 3)
        {
            Instantiate(damaged2, transform.position, Quaternion.identity);
            health--;
        }
        else if (health == 2)
        {
            Instantiate(damaged3, transform.position, Quaternion.identity);
            health--;
        }
        else if (health== 1)
        {
            health--;
            Instantiate(died, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
