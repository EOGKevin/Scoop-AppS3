using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public static ScoreManager Instance;

    public void Awake()
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

    public void AddScore(int newScore)
    {
        score += newScore;
        Score.Instance.ScoreText.text = score.ToString();
    }

    public int GetScore() { return score; }

}
