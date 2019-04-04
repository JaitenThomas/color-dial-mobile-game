using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public static WheelController instance;

    public float speed;
    public float minSpeed;

    public bool direction;

    public GameObject wheel;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetSpeedToLevel();   
    }

    public void SetSpeedToLevel()
    {


        if (SaveManager.instance.state.level != 1 && SaveManager.instance.state.level < 50)
        {
            speed = minSpeed + 1.0f * SaveManager.instance.state.level;
        }
        else if (SaveManager.instance.state.level == 1)
        {
           speed = minSpeed;
        }
        else if (SaveManager.instance.state.level >= 50)
        {
            speed = 130;
        }
    }

    void Update()
    {
        if (WheelManager.instance.isInAnimation == false)
        {
            if (direction == false)
            {
                wheel.transform.Rotate(0, 0, speed * Time.deltaTime);
            }

            else if (direction == true)
            {
                wheel.transform.Rotate(0, 0, -speed * Time.deltaTime);
            }

            if (Input.GetMouseButtonDown(0))
            {
                direction = !direction;
            }
        }

        
    }
}
