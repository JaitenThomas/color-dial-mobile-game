using Peculia.Time;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


public class UguiSampleController : MonoBehaviour
{

    public static UguiSampleController instance;

    private static int[] FREE_GIFT_COIN_TABLE = new int[] { 100, 125, 150, 200 };

    public int waitSeconds = 3600;

    public GameObject invalidNode;
    public GameObject waitingNode;
    public GameObject canSendNode;

    //public Image giftBoxImage;
    public Text waitingText;
    //public CoinController coinController;

    public int hours;
    public int mins;
    public int secs;

    public bool startCountDown;



    public int check;
    public bool isCollectingGift;

    public Text countDownText;
    public Text TapText;

    public Button spinButton;
    public Button tapButton;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        //PlayerPrefs.DeleteAll();

    }


    enum TimerState
    {
        INITIAL,
        INVALID,
        WAITING,
        CAN_SEND,
    }

    private readonly Color canSendColor = Color.white;
    private readonly Color cannotSendColor = new Color(1, 1, 1, 0.5f);

    private TimerState timerState = TimerState.INITIAL;

    private TimerState GetTimerState()
    {
        if (FreeGiftTimer.IsValid())
        {
            if (FreeGiftTimer.CanSend())
            {
                return TimerState.CAN_SEND;
            }
            else
            {
                return TimerState.WAITING;
            }
        }
        else
        {
            return TimerState.INVALID;
        }
    }

    void Update()
    {

        var newTimerState = GetTimerState();
        if (newTimerState != timerState)
        {
            timerState = newTimerState;
            ChangeScreen();
        }

        switch (timerState)
        {
            case TimerState.WAITING:

                if (isCollectingGift == false)
                {

                    var sec = FreeGiftTimer.GetRemainingTime();

                    hours = FreeGiftTimer.GetRemainingTime() / 3600;
                    mins = (FreeGiftTimer.GetRemainingTime() % 3600) / 60;
                    secs = (FreeGiftTimer.GetRemainingTime() % 3600) % 60;

                    //Debug.Log (hours);
                    //Debug.Log (mins);
                    //Debug.Log (secs); 

                    //FreeGiftTimer.SetNextWait(0);

                waitingText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, secs);

                    //	waitingText.text = string.Format ("{0} sec", sec);
                }
                break;
        }
    }

 

    private void ChangeScreen()
    {
        switch (timerState)
        {
            case TimerState.CAN_SEND:
                // Can get a free gift.
                canSendNode.SetActive(true);
                invalidNode.SetActive(false);
                waitingNode.SetActive(false);
                TapText.gameObject.SetActive(true);
                spinButton.interactable = true;
                tapButton.interactable = true;

                //giftBoxImage.gameObject.SetActive(true);
                //giftBoxImage.color = canSendColor;
                //giftBoxImage.transform.localEulerAngles = Vector3.zero;
                //giftBoxImage.transform.localScale = Vector3.one;
                break;
            case TimerState.WAITING:
                // Cannot get a free gift because the time has not yet come.
                if (isCollectingGift == false)
                {
                    waitingNode.SetActive(true);
                    invalidNode.SetActive(false);
                    canSendNode.SetActive(false);
                    TapText.gameObject.SetActive(false);
                    spinButton.gameObject.SetActive(true);
                    spinButton.interactable = false;
                    tapButton.interactable = false;


                }

                //FreeGiftTimer.SetNextWait (0); // To Reset

                //giftBoxImage.gameObject.SetActive(false);
                break;
            case TimerState.INVALID:
                // Cannot get a free gift because the clock is invalid.
                spinButton.interactable = false;
                tapButton.interactable = false;

                invalidNode.SetActive(true);
                waitingNode.SetActive(false);
                canSendNode.SetActive(false);
               

                //giftBoxImage.gameObject.SetActive(true);
                //giftBoxImage.color = cannotSendColor;
                break;
        }
    }

    public void OnGetButtonPressed()
    {
        FreeGiftTimer.SetNextWait(waitSeconds);

        // Hide all UIs.
        invalidNode.SetActive(false);
        waitingNode.SetActive(false);
        canSendNode.SetActive(false);

        gameObject.SetActive(false);  // Pause self action until coin demo will be finished.
                                      //var coin = FREE_GIFT_COIN_TABLE[Random.Range(0, FREE_GIFT_COIN_TABLE.Length)];
        gameObject.SetActive(true);  // Resume.

    }

}

