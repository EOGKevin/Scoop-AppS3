using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Firebase.Firestore;
using UnityEngine.SocialPlatforms.Impl;

public class LoadScoreBoard : MonoBehaviour
{
    private FirebaseFirestore db;
    public static LoadScoreBoard Instance;
    public List<Score> playerScores = new List<Score>();

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
                    Score playerScore = new Score(username.ToString(), Convert.ToInt32(highscore));
                    playerScores.Add(playerScore);
                }
            }
        }
        Debug.Log("Returner");
        return playerScores.ToArray();
    }
}
