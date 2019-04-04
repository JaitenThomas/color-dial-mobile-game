using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundColorChanger : MonoBehaviour
{

    public static BackgroundColorChanger instance;

    public List<Color> colorList;
    public Text text;

    public Color currentColor;
    public Color nextColor;

    public float timer;

    private void Awake()
    {
        /*
        DontDestroyOnLoad(this.transform.parent.gameObject);
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }
        */
    }

    private void Start()
    {

        

        colorList.AddRange(WheelColorManager.instance.wheelDefaultColors);

        nextColor = (Color)colorList[UnityEngine.Random.Range(0, colorList.Count)];

        colorList.Remove(nextColor);
    }

    void Update()
    {
        text.color = Color.Lerp(text.color, nextColor, Time.deltaTime * 5);

        timer += Time.deltaTime;

        if (timer >= 2)
        {

           


            nextColor = (Color)colorList[UnityEngine.Random.Range(0, colorList.Count)];


            colorList.Remove(nextColor);

            if(colorList.Count <= 0)
            {
                colorList.AddRange(WheelColorManager.instance.wheelDefaultColors);
            }


            timer = 0;
        }
	}


}
