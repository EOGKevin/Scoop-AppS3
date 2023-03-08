using Firebase.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class LoadScoreboard : MonoBehaviour
{
    #region Variables and Properties
    private FirebaseFirestore db;
    public static LoadScoreboard Instance;
    public List<Score> PlayScore = new List<Score>();
    #endregion

    void Start()
    {
        db = FirebaseFirestore.DefaultInstance;
    }

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

    public async Task<Score[]> QueryScoresAsync()
    {
        Query query = db.Collection("users").WhereGreaterThan("HighScore", 0).OrderByDescending("HighScore").Limit(10);
        QuerySnapshot snapshot = await query.GetSnapshotAsync();
        
        foreach (DocumentSnapshot document in snapshot.Documents)
        {
            object highscore;
            if (document.TryGetValue("HighScore", out highscore))
            {
                object username;
                if (document.TryGetValue("UserName", out username))
                {
                    Score playScore = new Score(username.ToString(), Convert.ToInt32(highscore));
                    PlayScore.Add(playScore);
                }
            }
        }
        Debug.Log("Return");
        return PlayScore.ToArray();

    }
}
