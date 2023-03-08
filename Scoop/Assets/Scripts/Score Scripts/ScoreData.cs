using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScoreData : MonoBehaviour
{
    public List<Score> Scores;

    public ScoreData()
    {
        Scores = new List<Score>();
    }
}
