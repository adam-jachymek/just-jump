using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float horizontal;
    [SerializeField] float speed = 5f;
    [SerializeField] public Rigidbody2D playerRigidBody;
    [SerializeField] private float jumpForce = 30f;

    public Boolean started = false;

    private float time = 0;

    private float jumpCount = 2;

    void Update()
    {
        time += Time.deltaTime;

        horizontal = Input.GetAxis("Horizontal");

        playerRigidBody.velocity = new Vector2(horizontal * speed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    private void jump()
    {

        if (!started)
        {
            started = true;
        }


        if (jumpCount > 0)
        {
            playerRigidBody.velocity = new Vector2(0, jumpForce);

            jumpCount = jumpCount - 1;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 2;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
