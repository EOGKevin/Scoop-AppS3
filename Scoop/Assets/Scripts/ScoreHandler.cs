using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    #region lol
    private int score = 0;
    public static ScoreHandler Instance;
    [SerializeField]
    Text scoreText;
    #endregion

    #region lloll
    private void Awake()
    {
        if (Instance == null && Instance != this)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region SM
    public void AddScore(int newScore)
    {
        score += newScore;

        scoreText.text = score.ToString();
    }

    public int GetScore() 
    { 
        return score; 
    }
    #endregion
}
