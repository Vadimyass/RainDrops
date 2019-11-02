using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometre : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    public float movementSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.acceleration.x, Input.acceleration.y) * movementSpeed;
        rb.AddForce(movement);
    }
    
}
