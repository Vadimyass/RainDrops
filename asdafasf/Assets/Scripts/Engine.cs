using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engine : MonoBehaviour
{
    public bool TheEnd = false;

    public int Score = 0;
    public event System.Action<Engine> OnUpdate;
    public static Engine ScoreText { get; private set; }

    public void Awake()
    {
        TheEnd = false;
        ScoreText = this;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        gameObject.transform.Translate(moveHorizontal * 0.15f, moveVertical * 0.15f, 0.0f);
    }
    public void AddScore()
    {
        Score = Score + 1;
        OnUpdate(this);
    }
    private void OnDestroy()
    {
        ScoreText = null;
    }


}

