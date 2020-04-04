using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    #region Variables

    //Public
    public bool gameStarted = false;

    //Private
    [SerializeField] private int score;
    [SerializeField] private Text scoreText;

    #endregion


    #region UnityFunctions

    void Start()
    {
        InvokeRepeating("UpdateScore",1.0f,1.0f);
    }

    void Update()
    {
    }

    #endregion

    private void UpdateScore()
    {
        if (gameStarted == true)
        {
            score++;
            scoreText.text = "" + score;
        }
    }
}