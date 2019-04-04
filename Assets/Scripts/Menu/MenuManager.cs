using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager instance;

    public GameObject[] settingButtons;
    public GameObject[] otherButtons;
    public GameObject settingButton;

    public bool settingBool;

    public Image soundButtonIconImage;

    public Sprite soundOnImage;
    public Sprite soundOffImage;

    public Image googlePlayButtonIconImage;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        CheckSoundState();

    }

    public void Play()
    {
        ToScene("Main");
    }

    public void GooglePlayButtonLogin()
    {
        GPG_MANAGER.instance.ButtonLogin();
        CheckLoginStatus();
    }

    public void CheckLoginStatus()
    {
        if (Social.localUser.authenticated == false)
        {
            googlePlayButtonIconImage.color = Color.black;
        }

        if (Social.localUser.authenticated == true)
        {
            googlePlayButtonIconImage.color = Color.white; 
        }
    }
    
    public void ToggleSettings()
    {
        if (settingBool == false)
        {
            settingButton.GetComponent<Animator>().Play("Rotate");
            
            foreach (GameObject item in settingButtons)
            {
                item.gameObject.SetActive(true);
            }

            foreach (GameObject item in otherButtons)
            {
                item.gameObject.SetActive(false);
            }
            settingBool = true;
        }

        else if (settingBool == true)
        {
            settingButton.GetComponent<Animator>().Play("ReverseRotate");
           
            foreach (GameObject item in settingButtons)
            {
                item.gameObject.SetActive(false);
            }

            foreach (GameObject item in otherButtons)
            {
                item.gameObject.SetActive(true);
            }

            settingBool = false;
        }
    }

    public void ToggleSound()
    {
        SaveManager.instance.state.sound = !SaveManager.instance.state.sound;


        if (SaveManager.instance.state.sound == false)
        {
            soundButtonIconImage.sprite = soundOffImage;
        }

        else if (SaveManager.instance.state.sound == true)
        {
            soundButtonIconImage.sprite = soundOnImage;
        }

        SaveManager.instance.Save();
    }

    public void CheckSoundState()
    {
        if (SaveManager.instance.state.sound == false)
        {
            soundButtonIconImage.sprite = soundOffImage;
        }

        else if (SaveManager.instance.state.sound == true)
        {
            soundButtonIconImage.sprite = soundOnImage;
        }
    }

    public void ToStorePage()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.Perplex.ColorDial");
    }

    public void ToScene(string _name)
    {
       LevelChanger.instance.FadeToLevel(_name);
    }
}
