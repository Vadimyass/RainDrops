using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreGUI : MonoBehaviour
{
    public Text Scoregui;
    private void Start()
    {
       Engine.ScoreText.OnUpdate += UpdateUI;
    }
    void UpdateUI(Engine score )
    {
        Scoregui.text = "Score:" + score.Score.ToString();
    }
}
