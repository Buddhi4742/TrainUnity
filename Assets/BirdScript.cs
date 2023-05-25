using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        gameObject.name = "Bird1";
        
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            birdRigidbody.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
