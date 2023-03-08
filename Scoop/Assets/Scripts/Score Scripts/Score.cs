using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score
{
    public static Score Instance;
    public Text ScoreText;

    public string name;
    public int score;

    public Score(string name, int score)
    {
        this.name = name;
        this.score = score; 
    }
}
