using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;

public class AdMobManager : MonoBehaviour
{

    private static AdMobManager instance;
    public static AdMobManager Instance { get { return instance; } }

    public BannerView bannerView;
    private RewardBasedVideoAd rewardBasedVideo;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    public void Start()
    {
        if (SaveManager.instance.state.broughtAds == false)
        {
            // Initialize the Google Mobile Ads SDK.
            MobileAds.Initialize("ca-app-pub-8755169433028902~3835672962"); // My App ID

            RequestBanner();
        }

      



        //Debug.Log ("Create");
    }

    public void RequestBanner()
    {

        //string adUnitId = "ca-app-pub-3940256099942544/6300978111"; //Test Banner
        string adUnitId = "ca-app-pub-8755169433028902/5461931042"; // Real Banner

        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        /* FOR TESTING
        AdRequest request = new AdRequest.Builder()
            .AddTestDevice(AdRequest.TestDeviceSimulator)
            .AddTestDevice(SystemInfo.deviceUniqueIdentifier).Build();

        */

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
       
        bannerView.Show();

      

        // bannerView.OnAdLoaded += HandleOnAdLoaded;
    }



    void HandleOnAdLoaded(object a, EventArgs args)
    {
        print("loaded");
        ShowBanner();
    }

    public void ShowBanner()
    {
        bannerView.Show();
    }

    public void HideBanner()
    {
        bannerView.Hide();
    }



    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        //Resume Play Sound

    }



}
