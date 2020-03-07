using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runspeed = 40f;
    public GameObject wintext;
    public GameObject losstext;
    public GameObject canvas;

    private float horizontalMove = 0f;
    private bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * runspeed * Time.fixedDeltaTime, false, jump);
        jump = false;
        if (transform.position.y < -5f)
        {
            Instantiate(losstext, canvas.transform);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Instantiate(wintext, canvas.transform);
            Destroy(gameObject);
        }
    }
}
