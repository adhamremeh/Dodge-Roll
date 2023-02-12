using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
    public Text Sc0re;
    public Text HI_Sc0re;

    public GameObject DeadMenu;
    public GameObject Spawner1;
    public GameObject Spawner2;

    private float Score_Time;
    public static int Ads;
    public int Real_Score;
    public int Real_HI_Score;

    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        Real_HI_Score = PlayerPrefs.GetInt("HISCORE");
    }

    // Update is called once per frame
    void Update()
    {

        if (Real_Score == 200)
        {
            Spawner1.SetActive(true);
        }
        else if (Real_Score == 400)
        {
            Spawner2.SetActive(true);
        }
        
        if (!dead)
        {
            Score_Time += Time.deltaTime * 6;
            Real_Score = (int)Score_Time;
            Sc0re.text = Real_Score.ToString();
            HI_Sc0re.text = Real_HI_Score.ToString();
            if (Real_Score >= Real_HI_Score)
            {
                Real_HI_Score = Real_Score;
            }
        }
        else
        {
            PlayerPrefs.SetInt("HISCORE", Real_HI_Score);
            DeadMenu.SetActive(true);
            if (Social.localUser.authenticated)
            {
                SignIn.PostToLeaderboard(Real_HI_Score);
            }
        }

        if (Ads >= 3)
        {
            FindObjectOfType<ADs>().Ad();
            Ads = 0;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Ads++;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Ads++;
    }
    public void LeaderBoard()
    {
        SignIn.ShowLeaderboarUI();
    }

}
