using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{

    public static Marker instance;

    private SpriteRenderer sr;

    public bool correct;

    public Color lastColor;
    public List<Color> tempColors;
   
    public LayerMask mask;

    public bool isObject;


    private List<GameObject> allObjectsOfChoosenColor;
    private GameObject lastHit;
    public bool twice;
    public bool check;

    //For checking if the color has changed before
    public bool firstTime;

    public Color choosenColor;

    public bool onSameColor;

    public GameObject outline;

    public GameObject currentSector;
 



    private void Awake()
    {
        instance = this;

        sr = GetComponent<SpriteRenderer>();

        ResetTempColors();
    }

    void Start()
    {
        
    }

    void Update()
    {

     

        
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(0, transform.position.y), Vector2.down, 0.5f, mask);

        UIManager.instance.background.color = Color.Lerp(UIManager.instance.background.color, choosenColor, Time.deltaTime * 10);

        Debug.DrawRay(new Vector2(0, transform.position.y), Vector2.down * 0.5f, Color.black);

        if (hit && GameManager.instance.started == true)
        {

            if (hit.transform.gameObject.tag == "Section" && sr.color == hit.transform.gameObject.GetComponent<SpriteRenderer>().color && UIManager.instance.gameOver == false)
            {

                if (check == true)
                {
                    return;
                }


                if (twice == true)
                {
                    correct = true;
                }

                else
                {
                    correct = false;
                }







            }

            else if (hit.transform.gameObject.tag == "Section" && sr.color != hit.transform.gameObject.GetComponent<SpriteRenderer>().color && UIManager.instance.gameOver == false)
            {
                //If marker goes past the correct color gameover

                if (check == true)
                {
                    check = false;
                    return;
                }


                //If marker goes past the correct color gameover
                if (correct == true && twice == true)
                {

                    StartCoroutine(WaitForGameOver());

                }

                else
                {
                    twice = true;

                }

                correct = false;
            }


            if (Input.GetMouseButtonDown(0) && correct == true && GameManager.instance.started == true && UIManager.instance.gameOver == false)
            {

                check = true;
                twice = false;




                //Check if the section hit has the star on it, if it does player gets a star and destory it
                if (hit.transform.GetChild(0).childCount > 0)
                {
                    AudioManager.instance.sounds[0].source.volume = 0;
                    AudioManager.instance.Play("Star");

                    UIManager.instance.AddStar(1);
                    Destroy(hit.transform.GetChild(0).GetChild(0).gameObject);

                }

                else
                {
                    AudioManager.instance.sounds[0].source.volume = 1;
                }

                UIManager.instance.ReduceCounter(-1);



                if (UIManager.instance.levelCompleted == false)
                {
                    lastHit = hit.transform.gameObject;
                    ChangeColor();
                }







              

            }

            else if (Input.GetMouseButtonDown(0) && correct == false && GameManager.instance.started == true && UIManager.instance.gameOver == false)
            {
                Debug.Log("1");
                //Level Failed
               
                UIManager.instance.GameOver();
            }

            
        }
        


    }

    IEnumerator WaitForGameOver()
    {
        yield return new WaitForSeconds(0.01f);
       
        UIManager.instance.GameOver();
    }

    public void DefaultColor()
    {
        sr.color = UIManager.instance.defaultColor;
    }

    public void ChangeColor()
    {
        if (firstTime == false && UIManager.instance.levelCompleted == false)
        {
            firstTime = true;
            
            sr.color = tempColors[Random.Range(3, tempColors.Count)];
            choosenColor = sr.color;
            lastColor = sr.color;
   

        }

        else if (UIManager.instance.levelCompleted == false)
        {
            //Grab the index of the color the is active from the currentColors list
            int index = WheelColorManager.instance.wheelDefaultColors.IndexOf(lastColor);

            Color colorLeft;
            Color colorRight;

            if (index != 0)
            {
                colorLeft = WheelColorManager.instance.wheelDefaultColors[index - 1];
            }
            else
            {
                colorLeft = WheelColorManager.instance.wheelDefaultColors[index + 4];
            }

            tempColors.Remove(colorLeft);

            if (index != 4)
            {
                colorRight = WheelColorManager.instance.wheelDefaultColors[index + 1];
            }

            else
            {
                colorRight = WheelColorManager.instance.wheelDefaultColors[index - 4];
            }

            tempColors.Remove(colorRight);

            choosenColor = tempColors[Random.Range(0, tempColors.Count)];

            sr.color = choosenColor;

            //outline.GetComponent<SpriteRenderer>().color = sr.color;
           
            //WheelController.instance.speed = Random.Range(80, 100);


            lastColor = choosenColor;

            tempColors.Add(colorLeft);
            tempColors.Add(colorRight);


            ChooseStarSpawn(choosenColor);

            
        }
        
    }

    public void ChooseStarSpawn(Color _choosenColor)
    {
        int indexOfLastHit = WheelManager.instance.wheelParts.IndexOf(lastHit);

        if (WheelController.instance.direction == true)
        {
            //Debug.Log(indexOfLastHit + 1);
            for (int i = indexOfLastHit + 1; i <= WheelManager.instance.wheelParts.Count; i++)
            {

                if (i == 15)
                {
                    i = 0;
                }


                if (WheelManager.instance.wheelParts[i].gameObject.GetComponent<SpriteRenderer>().color == _choosenColor)
                {
                    WheelManager.instance.wheelParts[i].gameObject.GetComponent<WheelPart>().SpawnStar();
                    break;
                }

            }
        }


        else if (WheelController.instance.direction == false)
        {
            for (int i = indexOfLastHit - 1; i < WheelManager.instance.wheelParts.Count; i--)
            {
                if (i < 0)
                {
                    i = WheelManager.instance.wheelParts.Count - 1;
                }

                if (WheelManager.instance.wheelParts[i].gameObject.GetComponent<SpriteRenderer>().color == _choosenColor)
                {
                    WheelManager.instance.wheelParts[i].gameObject.GetComponent<WheelPart>().SpawnStar();
                    break;
                }
            }
        }
    }




    public void ResetTempColors()
    {
        
      //  Debug.Log("reset");
        tempColors.Clear();
        tempColors = new List<Color>();
        tempColors.AddRange(WheelColorManager.instance.wheelDefaultColors);
    }
  
}
