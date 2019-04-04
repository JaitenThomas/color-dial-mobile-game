using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoogleRequest : MonoBehaviour
{

    void Start()
    {
        MenuManager.instance.CheckLoginStatus();
    }

    void Update()
    {

    }

    public void ShowLeaderboard()
    {
        GPG_MANAGER.instance.OnShowLeaderboard();
    }
}
