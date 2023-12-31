using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{
    PlayerScript playerScript;
    CharcterSelectMenu characterSelectMenu;


    public string Menu;
    public string MangoMayhem;

    public bool stopScore;
    public bool isAlive;

    public GameObject Coins;
    public GameObject GameOver;
    public GameObject Running;
    public GameObject CurrentPlayer;

    void Start()
    {
        GameOver.SetActive(false);
        Running.SetActive(true);

        
        stopScore = false;

        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
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
        StartCoroutine(ReturnToMenu());
        stopScore = true;
    }

    public void Retry()
    {
        CurrentPlayer = GameObject.FindGameObjectWithTag("Player");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(RetryGame());
    }


    IEnumerator ReturnToMenu()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        isAlive = true;
        

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Menu, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        Destroy(GameObject.FindWithTag("Player"));

        //SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));
        SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));

        Time.timeScale = 1;

        //Destroy(GameObject.FindWithTag("Player"));

        SceneManager.UnloadSceneAsync(currentScene);

        Instantiate(Coins);

    }

    IEnumerator RetryGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        isAlive = true;


        //SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("Player"), SceneManager.GetSceneByName(MangoMayhem));
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.MoveGameObjectToScene(CurrentPlayer, SceneManager.GetActiveScene());


        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        


        Time.timeScale = 1;

        //Destroy(GameObject.FindWithTag("Player"));

        SceneManager.UnloadSceneAsync(currentScene);

        Instantiate(Coins);

    }
}