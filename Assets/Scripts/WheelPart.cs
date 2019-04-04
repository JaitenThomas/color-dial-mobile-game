using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPart : MonoBehaviour {

    public static WheelPart instance;

    public bool wasLast;

    public Transform starSpawnPosition;
    public GameObject star;

    public bool game;



    private void Awake()
    {
        instance = this;
    }

    void Start ()
    {
        if (game == true)
        {
            starSpawnPosition = transform.GetChild(0).transform;

        }


    }


    public void SpawnStar()
    {
       
        //1 in 7 chance
        if (Random.Range(0, 8) < 1)
        {
            GameObject _star = Instantiate(star, starSpawnPosition.position, Quaternion.identity);
           
            _star.transform.SetParent(starSpawnPosition);

            _star.transform.localEulerAngles = new Vector3(0,0,0);
        }
        else
        {
            return;
        }
    }
}
