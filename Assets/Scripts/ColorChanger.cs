using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour {

    public List<Color> colorList;
    public float delayTime;



	// Use this for initialization
	void Start () {
        

        StartCoroutine(ChangeColorAfterTime());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ChangeColorAfterTime()
    {
        Text text = gameObject.GetComponent<Text>();

        Color currentcolor;
        Color nextcolor;


        colorList.AddRange(WheelColorManager.instance.wheelDefaultColors);



        currentcolor = (Color)colorList[UnityEngine.Random.Range(0, colorList.Count)];


     

        text.color = currentcolor;

       


        while (true)
        {
          
            colorList.Remove(currentcolor);

            nextcolor = (Color)colorList[UnityEngine.Random.Range(0, colorList.Count)];
           
           
            colorList.Add(currentcolor);

            for (float t = 0; t < delayTime; t += Time.deltaTime)
            {
                text.color = nextcolor;
                yield return null;
            }
            currentcolor = nextcolor;
        }
    }
}
