using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinManager : MonoBehaviour
{
    public static SpinManager instance;

    public Text currencyText;

    public List<bool> wheelStates;

    public bool rewardShowing;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateCurrency(0);
        AddBools();
    }

    void Update()
    {

    }

    void AddBools()
    {
        wheelStates.Add(SaveManager.instance.state.item0);
        wheelStates.Add(SaveManager.instance.state.item1);
        wheelStates.Add(SaveManager.instance.state.item2);
        wheelStates.Add(SaveManager.instance.state.item3);
        wheelStates.Add(SaveManager.instance.state.item4);
        wheelStates.Add(SaveManager.instance.state.item5);
        wheelStates.Add(SaveManager.instance.state.item6);
        wheelStates.Add(SaveManager.instance.state.item7);
        wheelStates.Add(SaveManager.instance.state.item8);
        wheelStates.Add(SaveManager.instance.state.item9);
        wheelStates.Add(SaveManager.instance.state.item10);
        wheelStates.Add(SaveManager.instance.state.item11);
        wheelStates.Add(SaveManager.instance.state.item12);
        wheelStates.Add(SaveManager.instance.state.item13);
        wheelStates.Add(SaveManager.instance.state.item14);

    }

    public void UpdateBools()
    {
        SaveManager.instance.state.item0 = wheelStates[0];
        SaveManager.instance.state.item1 = wheelStates[1];
        SaveManager.instance.state.item2 = wheelStates[2];
        SaveManager.instance.state.item3 = wheelStates[3];
        SaveManager.instance.state.item4 = wheelStates[4];
        SaveManager.instance.state.item5 = wheelStates[5];
        SaveManager.instance.state.item6 = wheelStates[6];
        SaveManager.instance.state.item7 = wheelStates[7];
        SaveManager.instance.state.item8 = wheelStates[8];
        SaveManager.instance.state.item9 = wheelStates[9];
        SaveManager.instance.state.item10 = wheelStates[10];
        SaveManager.instance.state.item11 = wheelStates[11];
        SaveManager.instance.state.item12 = wheelStates[12];
        SaveManager.instance.state.item13 = wheelStates[13];
        SaveManager.instance.state.item14 = wheelStates[14];

        SaveManager.instance.Save();

    }

    public void UpdateCurrency(int _amount)
    {
        Debug.Log("Rewards");
        SaveManager.instance.state.currency += _amount;
        currencyText.text = SaveManager.instance.state.currency.ToString();
        SaveManager.instance.Save();
    }

    public void DisplayAd()
    {
        UnityAdManager.instance.ShowRewardAd();
    }

    public void ToHome()
    {
        SaveManager.instance.Save();
        LevelChanger.instance.FadeToLevel("Menu");
    }


}
