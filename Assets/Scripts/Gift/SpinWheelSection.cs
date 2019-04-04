using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpinWheelSection : MonoBehaviour {

    public int amount;
    public bool isSpecial;
    public bool isReset;

    public bool once;

    public GameObject wonWheel;
    public Text rarietyWon;
    public GameObject wonHolder;

    void Start()
    {
        wonHolder.SetActive(false);
    }


    void Update()
    {

    }

    public void RewardPlayer()
    {


        if (isSpecial == true)
        {
            SpinManager.instance.rewardShowing = true;
            wonHolder.SetActive(true);
            int chance = Random.Range(1, 17);
            Debug.Log(chance);

            if (chance == 1 || chance == 2 || chance == 3 || chance == 4 || chance == 5 || chance == 6)
            {
                int index = Random.Range(1, 3);
                SpinManager.instance.wheelStates[index] = true;
                SetWonWheelColor(index);
                SetText("COMMON");
                rarietyWon.gameObject.SetActive(true);
                Debug.Log("COMMON");
            }


            else if (chance == 7 || chance == 8 || chance == 9 || chance == 10)
            {
                int index = Random.Range(4, 7);
                SpinManager.instance.wheelStates[index] = true;
                SetWonWheelColor(index);
               
                SetText("RARE");
                rarietyWon.gameObject.SetActive(true);
                Debug.Log("RARE");

            }

            else if (chance == 11 || chance == 12 || chance == 13)
            {
                int index = Random.Range(7, 10);
                SpinManager.instance.wheelStates[index] = true;
                SetWonWheelColor(index);
                SetText("EPIC");
                rarietyWon.gameObject.SetActive(true);
                Debug.Log("EPIC");
            }

            else if (chance == 14 || chance == 15)
            {
                int index = Random.Range(10, 13);
                SpinManager.instance.wheelStates[index] = true;
                SetWonWheelColor(index);
                SetText("LEGENDARY");
                rarietyWon.gameObject.SetActive(true);
                Debug.Log("LEGENDARY");
            }

            else if(chance == 16)
            {
                int index = Random.Range(13, 16);
                SpinManager.instance.wheelStates[index] = true;
                SetWonWheelColor(index);
                SetText("MYSTERY");
                rarietyWon.gameObject.SetActive(true);
                Debug.Log("MYSTERY");
            }
            
    
            //Debug.Log("Special!!");
            

            SpinManager.instance.UpdateBools();
        }

        else
        {
            SpinManager.instance.UpdateCurrency(amount);
        }
    }

    void SetWonWheelColor(int _index)
    {
        wonWheel.GetComponent<Animator>().Play("IncreaseSize");
       
        wonWheel.transform.GetChild(0).GetChild(0).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][0];
        wonWheel.transform.GetChild(0).GetChild(1).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][1];
        wonWheel.transform.GetChild(0).GetChild(2).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][2];
        wonWheel.transform.GetChild(0).GetChild(3).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][3];
        wonWheel.transform.GetChild(0).GetChild(4).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][4];
        wonWheel.transform.GetChild(0).GetChild(5).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][0];
        wonWheel.transform.GetChild(0).GetChild(6).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][1];
        wonWheel.transform.GetChild(0).GetChild(7).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][2];
        wonWheel.transform.GetChild(0).GetChild(8).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][3];
        wonWheel.transform.GetChild(0).GetChild(9).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][4];
        wonWheel.transform.GetChild(0).GetChild(10).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][0];
        wonWheel.transform.GetChild(0).GetChild(11).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][1];
        wonWheel.transform.GetChild(0).GetChild(12).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][2];
        wonWheel.transform.GetChild(0).GetChild(13).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][3];
        wonWheel.transform.GetChild(0).GetChild(14).GetComponent<RawImage>().color = WheelColorManager.instance.allColorList[_index][4];


    }

    void SetText(string _name)
    {
        rarietyWon.text = _name;
    }

    
    
}
