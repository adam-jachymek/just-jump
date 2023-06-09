using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    [SerializeField] float speed = 5f;
    [SerializeField] public Rigidbody2D playerRigidBody;
    [SerializeField] private float jumpForce = 30f;

    public Boolean started = false;

    private float time = 0;

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

        playerRigidBody.velocity = new Vector2(0, jumpForce);
    }
}
