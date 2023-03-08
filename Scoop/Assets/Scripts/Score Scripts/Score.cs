using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score : MonoBehaviour
{
    public string uname;
    public float score;

    public Score(string name, float score)
    {
        this.name = name;
        this.score = score; 
    }
}
