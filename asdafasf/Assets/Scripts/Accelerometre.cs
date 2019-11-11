using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometre : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    public float speed;
    private Quaternion localRotation;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        localRotation = transform.rotation;
    }

    void Update()
    {
        dirX = Input.acceleration.x * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
        localRotation.x += Input.acceleration.x * speed;
        localRotation.y += Input.acceleration.y * speed;
        
        transform.rotation = localRotation;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
