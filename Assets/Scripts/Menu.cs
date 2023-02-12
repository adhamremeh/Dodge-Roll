using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static int AR_EN;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void LeaderBoard()
    {
        SignIn.ShowLeaderboarUI();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
