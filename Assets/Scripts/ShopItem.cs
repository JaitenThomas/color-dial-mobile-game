using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public enum Rariety{
        common,
        rare,
        epic,
        legendary,
        mystery
    }

    public Rariety rariety;

    public int index;
    public Image overlay;
    public int cost;

    

    void Start()
    {
        CheckActive();
    }

    void Update()
    {
        
    }

    public void CheckActive()
    {
        if (ShopManager.instance.itemsBroughtState[index] == true)
        {
           // Debug.Log("true");
            overlay.gameObject.SetActive(false);
            ShopManager.instance.buyButton.gameObject.SetActive(false);
            ShopManager.instance.selectButton.gameObject.SetActive(true);
        }

        else
        {
            //   Debug.Log("false");

            overlay.gameObject.SetActive(true);

            if (rariety == Rariety.mystery)
            {
                ShopManager.instance.buyButton.gameObject.SetActive(false);
                ShopManager.instance.selectButton.gameObject.SetActive(false);
            }

            else
            {
               
                ShopManager.instance.buyButton.gameObject.SetActive(true);
                ShopManager.instance.selectButton.gameObject.SetActive(false);
            }

           
        }

     
    }
}

 
