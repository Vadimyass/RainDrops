using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Engine.ScoreText.AddScore();
        Destroy(gameObject);
    }
}
