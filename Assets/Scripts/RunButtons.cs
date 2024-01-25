using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{



    public string Menu;
    public string MangoMayhem;

    public bool stopScore;
    public bool isAlive;
    public bool test;

    public GameObject Coins;
    public GameObject GameOver;
    public GameObject Running;
    public GameObject Score;
    

    void Start()
    {
        GameOver.SetActive(false);
        Running.SetActive(true);

        
        stopScore = false;


    }

    public void Update()
    {
        if (isAlive == true)
        {
            GameOver.SetActive(false);
            Running.SetActive(true);
        }

        if (isAlive == false)
        {
            GameOver.SetActive(true);
            Running.SetActive(false);
        }

       
    }

    public void Quit()
    {
        StartCoroutine(QuitGame());
        stopScore = true;
    }

    



    

    IEnumerator QuitGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Menu, LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(GameObject.FindWithTag("Coins"), SceneManager.GetSceneByName(Menu));

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SceneManager.UnloadSceneAsync(currentScene);

    }
}