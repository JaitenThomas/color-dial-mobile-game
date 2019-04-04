using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GPG_MANAGER : MonoBehaviour
{

    public static GPG_MANAGER instance;

  


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }
    }


    void Start()
    {
        PlayGamesPlatform.Activate();
        //PlayGamesPlatform.DebugLogEnabled = true;

        if (Social.localUser.authenticated == false && SaveManager.instance.state.first == false)
        {
            SaveManager.instance.state.first = true;
            AutoLogin();
            SaveManager.instance.Save();
        }

        else
        {
            SilentLogin();
        }
    }



    public void AutoLogin()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                SaveManager.instance.state.googleService = true;
                MenuManager.instance.CheckLoginStatus();
                SaveManager.instance.Save();
                Debug.Log("Logged In");
            }
            else
            {
                SaveManager.instance.state.googleService = false;
                MenuManager.instance.CheckLoginStatus();
                SaveManager.instance.Save();
                Debug.Log("failed to log in");
            }
        });
    }

    public void SilentLogin()
    {

        PlayGamesPlatform.Instance.Authenticate((bool success) =>
        {
            if (success)
            {
                SaveManager.instance.state.googleService = true;
                MenuManager.instance.CheckLoginStatus();
                SaveManager.instance.Save();
                Debug.Log("Logged In");
            }
            else
            {
                SaveManager.instance.state.googleService = false;
                MenuManager.instance.CheckLoginStatus();
                SaveManager.instance.Save();
                Debug.Log("failed to log in");
            }
        }, true);
    }

    public void ButtonLogin()
    {
        if (Social.localUser.authenticated == false)
        {
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    SaveManager.instance.state.googleService = true;
                    MenuManager.instance.CheckLoginStatus();
                    SaveManager.instance.Save();
                    Debug.Log("Logged In");
                }
                else
                {
                    SaveManager.instance.state.googleService = false;
                    MenuManager.instance.CheckLoginStatus();
                    SaveManager.instance.Save();
                    Debug.Log("failed to log in");
                }
            });
        }

        else if (Social.localUser.authenticated == true)
        {
            SaveManager.instance.state.googleService = false;
            PlayGamesPlatform.Instance.SignOut();
            MenuManager.instance.CheckLoginStatus();
            SaveManager.instance.Save();
        }
    }

    public void OnAddScoreToLeaderboard(int _score, string _leaderboard)
    {
        Social.ReportScore(_score, _leaderboard, (bool success) => 
        {

        });
    }

    public void OnShowLeaderboard()
    {

        if (Social.localUser.authenticated == true)
        {
            //show all leaderboards
            Social.ShowLeaderboardUI();
            //((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(GPGSIds.leaderboard_top_level); //Show current active leaderboard
        }

        else if (Social.localUser.authenticated == false)
        {
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    SaveManager.instance.state.googleService = true;
                    Social.ShowLeaderboardUI();
                    MenuManager.instance.CheckLoginStatus();
                    SaveManager.instance.Save();
                    Debug.Log("Logged In");
                }
                else
                {
                    SaveManager.instance.state.googleService = false;
                    MenuManager.instance.CheckLoginStatus();
                    SaveManager.instance.Save();
                    Debug.Log("failed to log in");
                }
            });



        }

        SaveManager.instance.Save();

    }
}
