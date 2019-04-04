using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class UnityAdManager : MonoBehaviour
{

    public static UnityAdManager instance;

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

    public void ShowRewardAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult});
        }
    }

    public void ShowAfterGameAd()
    {
        if (Advertisement.IsReady() && SaveManager.instance.state.broughtAds == false)
        {
            Advertisement.Show("video", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Gain stars");



                if (SceneManager.GetActiveScene().name == "Spinner")
                {
                    SpinManager.instance.UpdateCurrency(25);
                }

                else if (SceneManager.GetActiveScene().name == "Shop")
                {
                    ShopManager.instance.UpdateCurrency(25);
                }

                break;
            case ShowResult.Skipped:
                Debug.Log("Player did not fully watch the ad");
                break;
            case ShowResult.Failed:
                Debug.Log("Player fail to launch the ad ? internet?");
                break;
           
        }
    }
}
