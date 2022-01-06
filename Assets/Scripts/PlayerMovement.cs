using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float moveSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(Time.fixedDeltaTime * moveSpeed, false, false);
        //movespeed is approximately 20.4 blocks/second
    }

    void FixedUpdate()
    {

    }

    public void GiveUp()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
