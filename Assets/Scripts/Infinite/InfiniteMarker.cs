using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteMarker : MonoBehaviour
{
    public static InfiniteMarker instance;

    private SpriteRenderer sr;

    public bool correct;

    public Color lastColor;
    public List<Color> tempColors;


    public Color defaultColor;

    public LayerMask mask;

    public bool isObject;


    private List<GameObject> allObjectsOfChoosenColor;
    private GameObject lastHit;

    private bool twice;
    private bool check;

    public bool firstTime;

    public GameObject outline;

    public Color choosenColor;

    public GameObject wheel;


    private void Awake()
    {
        instance = this;

        sr = GetComponent<SpriteRenderer>();

        //Fills the temp color array with the colors from the main array
        tempColors.AddRange(WheelColorManager.instance.wheelDefaultColors);
    }

    void Start()
    {
     

    }

    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(new Vector2(0, transform.position.y), Vector2.down, 0.3f, mask);

        InfiniteUIManager.instance.background.color = Color.Lerp(InfiniteUIManager.instance.background.color, choosenColor, Time.deltaTime * 10);


        Debug.DrawRay(new Vector2(0, transform.position.y), Vector2.down * 0.3f, Color.black);

        if (hit)
        {
           
            //Check if the raycast hits the same color
            if (hit.transform.gameObject.tag == "Section" && sr.color == hit.transform.gameObject.GetComponent<SpriteRenderer>().color && InfiniteUIManager.instance.gameOver == false)
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

            else if (hit.transform.gameObject.tag == "Section" && sr.color != hit.transform.gameObject.GetComponent<SpriteRenderer>().color && InfiniteUIManager.instance.gameOver == false)
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

            if (Input.GetMouseButtonDown(0) && correct == true && InfiniteGameManager.instance.started == true && InfiniteUIManager.instance.gameOver == false)
            {
                check = true;
                twice = false;

                InfiniteUIManager.instance.AddScore(1);

              

               
                lastHit = hit.transform.gameObject;

               



                //Check if the section hit has the star on it, if it does player gets a star and destory it
                if (hit.transform.GetChild(0).childCount > 0)
                {
                    AudioManager.instance.sounds[0].source.volume = 0;
                    AudioManager.instance.Play("Star");

                    InfiniteUIManager.instance.AddStar(1);
                    Destroy(hit.transform.GetChild(0).GetChild(0).gameObject);

                }

                else
                {
                    AudioManager.instance.sounds[0].source.volume = 1;
                }

                IncreaseSpeed();
                ChangeColor();


            }

            else if (Input.GetMouseButtonDown(0) && correct == false && InfiniteGameManager.instance.started == true && InfiniteUIManager.instance.gameOver == false)
            {
                //Level Failed
                InfiniteUIManager.instance.GameOver();
            }
        }
        
    }

    IEnumerator WaitForGameOver()
    {

        yield return new WaitForSeconds(0.01f);
        InfiniteUIManager.instance.GameOver();
    }

    public void DefaultColor()
    {
        sr.color = defaultColor;
    }

    public void ChangeColor()
    {

        if (firstTime == false)
        {
            firstTime = true;

          

            sr.color = tempColors[Random.Range(3, tempColors.Count)];
            choosenColor = sr.color;
            lastColor = sr.color;


           // outline.GetComponent<SpriteRenderer>().color = sr.color;

        }

        else
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
          


            lastColor = choosenColor;

            tempColors.Add(colorLeft);
            tempColors.Add(colorRight);


            ChooseStarSpawn(choosenColor);

        }
    }

    public void IncreaseSpeed()
    {
        if (wheel.transform.GetComponent<WheelController>().speed < 130)
        {
            wheel.transform.GetComponent<WheelController>().speed += 1.0f;
        }

    }

    public void ChooseStarSpawn(Color _choosenColor)
    {
        int indexOfLastHit = WheelManager.instance.wheelParts.IndexOf(lastHit);

        if (WheelController.instance.direction == true)
        {
         //   Debug.Log(indexOfLastHit + 1);
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

}
