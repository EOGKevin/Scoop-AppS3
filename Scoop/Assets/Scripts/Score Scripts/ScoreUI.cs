using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    #region V&P
    [SerializeField] RowUi rowUi;
    #endregion

    #region Initialization Methods
    async void Start()
    {
        // Loader scorere fra databasen
        Score[] scores = await LoadScoreboard.Instance.QueryScoresAsync();
        for(int i = 0; i < scores.Length; i++)
        {
            // Repræsentere en række for hver score
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i+1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
    #endregion
}
