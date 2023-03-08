using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager.AddScore(new Score("eran", 6));
        scoreManager.AddScore(new Score("el", 66));

        var scores = scoreManager.GetHighScores().ToArray();
        for(int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i+1).ToString();
            row.uname.text = scores[i].uname;
            row.score.text = scores[i].score.ToString();
        }
    }
}
