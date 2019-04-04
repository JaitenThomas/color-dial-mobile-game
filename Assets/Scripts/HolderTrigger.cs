using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolderTrigger : MonoBehaviour {

    public GameObject holder;

    //Spin wheel button
    public Button button;

   //Return after won button
   public Button returnButton;
   


    //At the start of increase
    public void ButtonOff()
    {
        button.gameObject.SetActive(false);

        returnButton.gameObject.SetActive(true);
        returnButton.interactable = false;
    }

    //after increase is done
    public void ButtonOn()
    {
        button.gameObject.SetActive(false);

        returnButton.interactable = true;

    }

    //At  the end of shrink
    public void TurnOff()
    {
        button.gameObject.SetActive(true);
        returnButton.gameObject.SetActive(false);
        returnButton.interactable = false;
        holder.gameObject.SetActive(false);
        SpinManager.instance.rewardShowing = false;
    }
}
