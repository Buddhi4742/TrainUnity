using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird1";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            birdRigidbody.velocity = Vector2.up * flapStrength;
    }
}
