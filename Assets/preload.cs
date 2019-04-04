using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preload : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(ShowLogo());
	}
	
	// Update is called once per frame
	void Update () {



    }

    IEnumerator ShowLogo()
    {
        yield return new WaitForSeconds(0.1f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
