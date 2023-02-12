using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Auth();
    }

    void Auth()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
            }
            else
            {
            }
        });
    }

    public static void PostToLeaderboard(int newScore)
    {
        Social.ReportScore(newScore, GPGSIds.leaderboard_high_score, (bool success) =>
        {
            if (success)
            {
                Debug.Log("Posted new score to leaderboard");
            }
            else
            {
                Debug.LogError("Unable to post");
            }
        });
    }

    public static void ShowLeaderboarUI()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_high_score);
    }
}
