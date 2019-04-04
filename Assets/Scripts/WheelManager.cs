using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelManager : MonoBehaviour
{
    public static WheelManager instance;

    public List<GameObject> wheelParts;

    public Animator animator;

    public bool isInAnimation;

    public GameObject marker;

    public GameObject wheel;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        wheelParts[0].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[0];
        wheelParts[1].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[1];
        wheelParts[2].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[2];
        wheelParts[3].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[3];
        wheelParts[4].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[4];

        wheelParts[5].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[0];
        wheelParts[6].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[1];
        wheelParts[7].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[2];
        wheelParts[8].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[3];
        wheelParts[9].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[4];

        wheelParts[10].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[0];
        wheelParts[11].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[1];
        wheelParts[12].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[2];
        wheelParts[13].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[3];
        wheelParts[14].GetComponent<SpriteRenderer>().color = WheelColorManager.instance.wheelDefaultColors[4];



    }




    public void MoveOut()
    {
        isInAnimation = true;
        animator.Play("Wheel_Out");
    }

    public void MoveIn()
    {
        animator.Play("Wheel_In");

    }


    public void AnimationFinish()
    {
        isInAnimation = false;

        //turn on after transition

        //Reset the level completed
        UIManager.instance.levelCompleted = false;

   
        WheelController.instance.direction = false;

        UIManager.instance.startButton.SetActive(true);
    }

}
