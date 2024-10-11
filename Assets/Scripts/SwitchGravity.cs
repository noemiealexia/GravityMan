using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    private PlayerController player;

    public bool top;

    void Start()
    {
        player = GetComponent<PlayerController>();
        rigidBody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.gravityScale *= -1;
            Rotation();
        }
        
    }

    void Rotation()
    {
        if (!top)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);

        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        player.facingRight = !player.facingRight;
        top = !top;


    }


}
