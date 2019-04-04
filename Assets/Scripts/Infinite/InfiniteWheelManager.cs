using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteWheelManager : MonoBehaviour
{
    public static InfiniteWheelManager instance;

    public List<GameObject> wheelParts;


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

}
