using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 5;
    private float moveInput;
    public float deadZone = 8;
    public Logic logic;

    private Rigidbody2D rigidBody;

    public bool facingRight = true;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(moveInput * speed, rigidBody.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

        if (transform.position.y > deadZone || transform.position.y < -deadZone)
        {
            logic.ResetTimer();
            SceneManager.LoadScene(0);
        }


    }

    void Flip()
    {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }



}
