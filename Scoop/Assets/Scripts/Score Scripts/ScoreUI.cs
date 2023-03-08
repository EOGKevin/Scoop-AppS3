using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    #region VP
    public RowUI rowUi;
    #endregion

    #region IM
    async void Start()
    {
        //Læser scoreren fra Databasen
        Score[] scores = await LoadScoreBoard.Instance.QueryScoresAsync();
        for (int i = 0; i < scores.Length; i++)
        {
            var row Instantiate(rowUi, transform).GetComponent<RowUI>();
            row.rank.text = (i+1).ToString();
            row.name.text = scores[i].name;
            row.score = scores[i].score.toString();
        }
    }
    #endregion
}
