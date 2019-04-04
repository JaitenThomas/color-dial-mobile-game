using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    public GameObject[] wheels;

    public List<bool> itemsBroughtState;

    public GameObject[] shopButtons;

    public int[] costs;

    public int currentIndex;

    public Button selectButton;
    public Button buyButton;

    public Text currencyText;    

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        AddBools();


        //when adding a new one change wheels[0].transform.childCount, wheels[0], wheel0Colors[0];

        //Wheel 0
        for (int i = 0; i < wheels[0].transform.childCount; i++)
        {
            wheels[0].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[0];
            wheels[0].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[1];
            wheels[0].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[2];
            wheels[0].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[3];
            wheels[0].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[4];

            wheels[0].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[0];
            wheels[0].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[1];
            wheels[0].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[2];
            wheels[0].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[3];
            wheels[0].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[4];

            wheels[0].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[0];
            wheels[0].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[1];
            wheels[0].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[2];
            wheels[0].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[3];
            wheels[0].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel0Colors[4];

        }

        //Wheel 1
        for (int i = 0; i < wheels[1].transform.childCount; i++)
        {
            wheels[1].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[0];
            wheels[1].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[1];
            wheels[1].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[2];
            wheels[1].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[3];
            wheels[1].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[4];

            wheels[1].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[0];
            wheels[1].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[1];
            wheels[1].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[2];
            wheels[1].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[3];
            wheels[1].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[4];

            wheels[1].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[0];
            wheels[1].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[1];
            wheels[1].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[2];
            wheels[1].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[3];
            wheels[1].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel1Colors[4];
        }

        //Wheel 2
        for (int i = 0; i < wheels[2].transform.childCount; i++)
        {
            wheels[2].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[0];
            wheels[2].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[1];
            wheels[2].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[2];
            wheels[2].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[3];
            wheels[2].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[4];

            wheels[2].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[0];
            wheels[2].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[1];
            wheels[2].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[2];
            wheels[2].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[3];
            wheels[2].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[4];
        
            wheels[2].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[0];
            wheels[2].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[1];
            wheels[2].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[2];
            wheels[2].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[3];
            wheels[2].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel2Colors[4];
        }

        //Wheel 3
        for (int i = 0; i < wheels[3].transform.childCount; i++)
        {
            wheels[3].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[0];
            wheels[3].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[1];
            wheels[3].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[2];
            wheels[3].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[3];
            wheels[3].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[4];

            wheels[3].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[0];
            wheels[3].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[1];
            wheels[3].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[2];
            wheels[3].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[3];
            wheels[3].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[4];

            wheels[3].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[0];
            wheels[3].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[1];
            wheels[3].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[2];
            wheels[3].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[3];
            wheels[3].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel3Colors[4];
        }

        //Wheel 4
        for (int i = 0; i < wheels[4].transform.childCount; i++)
        {
            wheels[4].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[0];
            wheels[4].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[1];
            wheels[4].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[2];
            wheels[4].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[3];
            wheels[4].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[4];

            wheels[4].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[0];
            wheels[4].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[1];
            wheels[4].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[2];
            wheels[4].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[3];
            wheels[4].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[4];

            wheels[4].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[0];
            wheels[4].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[1];
            wheels[4].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[2];
            wheels[4].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[3];
            wheels[4].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel4Colors[4];
        }

        //Wheel 5
        for (int i = 0; i < wheels[5].transform.childCount; i++)
        {
            wheels[5].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[0];
            wheels[5].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[1];
            wheels[5].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[2];
            wheels[5].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[3];
            wheels[5].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[4];

            wheels[5].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[0];
            wheels[5].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[1];
            wheels[5].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[2];
            wheels[5].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[3];
            wheels[5].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[4];

            wheels[5].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[0];
            wheels[5].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[1];
            wheels[5].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[2];
            wheels[5].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[3];
            wheels[5].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel5Colors[4];
        }

        //Wheel 6
        for (int i = 0; i < wheels[6].transform.childCount; i++)
        {
            wheels[6].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[0];
            wheels[6].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[1];
            wheels[6].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[2];
            wheels[6].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[3];
            wheels[6].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[4];

            wheels[6].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[0];
            wheels[6].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[1];
            wheels[6].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[2];
            wheels[6].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[3];
            wheels[6].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[4];

            wheels[6].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[0];
            wheels[6].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[1];
            wheels[6].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[2];
            wheels[6].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[3];
            wheels[6].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel6Colors[4];
        }

        //Wheel 7
        for (int i = 0; i < wheels[7].transform.childCount; i++)
        {
            wheels[7].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[0];
            wheels[7].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[1];
            wheels[7].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[2];
            wheels[7].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[3];
            wheels[7].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[4];

            wheels[7].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[0];
            wheels[7].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[1];
            wheels[7].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[2];
            wheels[7].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[3];
            wheels[7].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[4];

            wheels[7].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[0];
            wheels[7].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[1];
            wheels[7].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[2];
            wheels[7].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[3];
            wheels[7].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel7Colors[4];
        }

        //Wheel 8
        for (int i = 0; i < wheels[8].transform.childCount; i++)
        {
            wheels[8].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[0];
            wheels[8].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[1];
            wheels[8].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[2];
            wheels[8].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[3];
            wheels[8].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[4];

            wheels[8].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[0];
            wheels[8].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[1];
            wheels[8].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[2];
            wheels[8].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[3];
            wheels[8].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[4];

            wheels[8].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[0];
            wheels[8].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[1];
            wheels[8].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[2];
            wheels[8].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[3];
            wheels[8].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel8Colors[4];
        }

        //Wheel 9
        for (int i = 0; i < wheels[9].transform.childCount; i++)
        {
            wheels[9].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[0];
            wheels[9].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[1];
            wheels[9].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[2];
            wheels[9].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[3];
            wheels[9].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[4];

            wheels[9].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[0];
            wheels[9].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[1];
            wheels[9].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[2];
            wheels[9].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[3];
            wheels[9].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[4];

            wheels[9].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[0];
            wheels[9].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[1];
            wheels[9].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[2];
            wheels[9].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[3];
            wheels[9].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel9Colors[4];
        }

        //Wheel 10
        for (int i = 0; i < wheels[10].transform.childCount; i++)
        {
            wheels[10].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[0];
            wheels[10].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[1];
            wheels[10].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[2];
            wheels[10].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[3];
            wheels[10].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[4];

            wheels[10].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[0];
            wheels[10].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[1];
            wheels[10].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[2];
            wheels[10].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[3];
            wheels[10].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[4];

            wheels[10].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[0];
            wheels[10].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[1];
            wheels[10].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[2];
            wheels[10].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[3];
            wheels[10].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel10Colors[4];
        }

        //Wheel 11
        for (int i = 0; i < wheels[11].transform.childCount; i++)
        {
            wheels[11].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[0];
            wheels[11].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[1];
            wheels[11].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[2];
            wheels[11].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[3];
            wheels[11].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[4];

            wheels[11].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[0];
            wheels[11].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[1];
            wheels[11].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[2];
            wheels[11].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[3];
            wheels[11].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[4];

            wheels[11].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[0];
            wheels[11].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[1];
            wheels[11].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[2];
            wheels[11].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[3];
            wheels[11].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel11Colors[4];
        }

        //Wheel 12
        for (int i = 0; i < wheels[12].transform.childCount; i++)
        {
            wheels[12].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[0];
            wheels[12].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[1];
            wheels[12].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[2];
            wheels[12].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[3];
            wheels[12].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[4];

            wheels[12].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[0];
            wheels[12].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[1];
            wheels[12].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[2];
            wheels[12].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[3];
            wheels[12].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[4];

            wheels[12].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[0];
            wheels[12].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[1];
            wheels[12].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[2];
            wheels[12].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[3];
            wheels[12].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel12Colors[4];
        }

        //Wheel 13
        for (int i = 0; i < wheels[13].transform.childCount; i++)
        {
            wheels[13].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[0];
            wheels[13].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[1];
            wheels[13].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[2];
            wheels[13].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[3];
            wheels[13].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[4];

            wheels[13].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[0];
            wheels[13].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[1];
            wheels[13].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[2];
            wheels[13].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[3];
            wheels[13].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[4];

            wheels[13].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[0];
            wheels[13].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[1];
            wheels[13].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[2];
            wheels[13].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[3];
            wheels[13].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel13Colors[4];
        }

        //Wheel 14
        for (int i = 0; i < wheels[14].transform.childCount; i++)
        {
            wheels[14].transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[0];
            wheels[14].transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[1];
            wheels[14].transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[2];
            wheels[14].transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[3];
            wheels[14].transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[4];

            wheels[14].transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[0];
            wheels[14].transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[1];
            wheels[14].transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[2];
            wheels[14].transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[3];
            wheels[14].transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[4];

            wheels[14].transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[0];
            wheels[14].transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[1];
            wheels[14].transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[2];
            wheels[14].transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[3];
            wheels[14].transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.wheel14Colors[4];
        }

        UpdateCurrency(0);
    }

    public void UpdateCurrency(int _amount)
    {
        SaveManager.instance.state.currency += _amount;
        currencyText.text = "" + SaveManager.instance.state.currency.ToString();
    }

    void AddBools()
    {
        itemsBroughtState.Add(SaveManager.instance.state.item0);
        itemsBroughtState.Add(SaveManager.instance.state.item1);
        itemsBroughtState.Add(SaveManager.instance.state.item2);
        itemsBroughtState.Add(SaveManager.instance.state.item3);
        itemsBroughtState.Add(SaveManager.instance.state.item4);
        itemsBroughtState.Add(SaveManager.instance.state.item5);
        itemsBroughtState.Add(SaveManager.instance.state.item6);
        itemsBroughtState.Add(SaveManager.instance.state.item7);
        itemsBroughtState.Add(SaveManager.instance.state.item8);
        itemsBroughtState.Add(SaveManager.instance.state.item9);
        itemsBroughtState.Add(SaveManager.instance.state.item10);
        itemsBroughtState.Add(SaveManager.instance.state.item11);
        itemsBroughtState.Add(SaveManager.instance.state.item12);
        itemsBroughtState.Add(SaveManager.instance.state.item13);
        itemsBroughtState.Add(SaveManager.instance.state.item14);

        UpdateBools();

    }

    void UpdateBools()
    {
        SaveManager.instance.state.item0 = itemsBroughtState[0];
        SaveManager.instance.state.item1 = itemsBroughtState[1];
        SaveManager.instance.state.item2 = itemsBroughtState[2];
        SaveManager.instance.state.item3 = itemsBroughtState[3];
        SaveManager.instance.state.item4 = itemsBroughtState[4];
        SaveManager.instance.state.item5 = itemsBroughtState[5];
        SaveManager.instance.state.item6 = itemsBroughtState[6];
        SaveManager.instance.state.item7 = itemsBroughtState[7];
        SaveManager.instance.state.item8 = itemsBroughtState[8];
        SaveManager.instance.state.item9 = itemsBroughtState[9];
        SaveManager.instance.state.item10 = itemsBroughtState[10];
        SaveManager.instance.state.item11 = itemsBroughtState[11];
        SaveManager.instance.state.item12 = itemsBroughtState[12];
        SaveManager.instance.state.item13 = itemsBroughtState[13];
        SaveManager.instance.state.item14 = itemsBroughtState[14];

        SaveManager.instance.Save();

    }

    public void ToHome()
    {
        LevelChanger.instance.FadeToLevel("Menu");
    }

    public void Select(int _index)
    {
        _index = currentIndex;

        SaveManager.instance.state.indexOfSelectedWheel = _index;

        GameObject.FindObjectOfType<WheelColorManager>().Start();

        SaveManager.instance.Save();

        
    }

    public void Buy(int _index)
    {
        _index = currentIndex;

        if (SaveManager.instance.state.currency >= costs[_index])
        {
            UpdateCurrency(-costs[_index]);
            Select(_index);

            itemsBroughtState[_index] = true;

            shopButtons[_index].GetComponent<ShopItem>().CheckActive();

            UpdateBools();
            SaveManager.instance.Save();
        }
    }

    public void ShowRewardVideo()
    {
        UnityAdManager.instance.ShowRewardAd();
    }
}
