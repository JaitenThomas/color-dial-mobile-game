using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static SceneController instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }

        else if (instance != null)
        {
            Destroy(this.gameObject);
        }

            
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void ToScene(string _name)
    {
        SceneManager.LoadScene(_name);
    }

    
}
