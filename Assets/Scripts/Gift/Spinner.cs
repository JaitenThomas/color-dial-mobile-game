using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spinner : MonoBehaviour
{

    public float reducer;
    public float multiplier = 1;
    bool round1 = false;
    public bool isStoped = false;
    public float increaser = 1;

    public GameObject needle;
    public Text tapToStartText;

    public bool once;

    public Button spinButton;
    public Button tapButton;

    public int spinCost;
   

    void Start()
    {
        reducer = Random.Range(0.01f, 0.03f);
        increaser = Random.Range(0.03f, 0.05f);


        needle.GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frameQ
    void Update()
    {

        if (isStoped == false)
        {
            if (multiplier > 0)
            {
                //transform.Rotate(Vector3.forward, speed);
                transform.Rotate(Vector3.forward, 1 * multiplier);
            }
            else
            {
                isStoped = true;
            }

            if (multiplier < 7 && !round1)
            {
                multiplier += increaser;
            }
            else
            {
                round1 = true;
            }

            if (round1 && multiplier > 0)
            {
                multiplier -= reducer;
            }
        }
       
    }

    public void Spin()
    {

        Debug.Log("Spin!");

        if (isStoped == true && SpinManager.instance.rewardShowing == false)
        {
            if (spinButton.interactable == true)
            {
                spinButton.interactable = false;
                tapButton.interactable = false;

            }


            if (isStoped == true)
            {

                Reset();
            }
        }
       
    }


    void Reset()
    {
        tapToStartText.gameObject.SetActive(false);
        multiplier = 1;
        reducer = Random.Range(0.03f, 0.05f);
        increaser = Random.Range(0.03f, 0.07f);
        round1 = false;
        isStoped = false;
        needle.GetComponent<Collider2D>().enabled = true;
        needle.GetComponent<Needle>().rewardOnce = false;
    }
}
