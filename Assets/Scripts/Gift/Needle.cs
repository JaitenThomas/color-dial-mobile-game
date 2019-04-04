using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needle : MonoBehaviour
{

    public Spinner _spinner;
    public Text scoretext;

    public bool rewardOnce;

    public GameObject wonWheel;

   


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (!_spinner.isStoped)
            return;
        else if (rewardOnce == false)
        {
            FindObjectOfType<Spinner>().tapToStartText.gameObject.SetActive(true);
            col.gameObject.GetComponent<SpinWheelSection>().RewardPlayer();
            UguiSampleController.instance.OnGetButtonPressed();
            rewardOnce = true;

        }




    }

    public void ResetAnimation()
    {
        wonWheel.GetComponent<Animator>().Play("Shrink");
    }



}
