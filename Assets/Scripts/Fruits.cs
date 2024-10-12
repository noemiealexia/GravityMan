using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{

    public Logic logic;
    public PlayerController player;

    private void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        logic.AddScore();
        Destroy(gameObject);

    }



}
