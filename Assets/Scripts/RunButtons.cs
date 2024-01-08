using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{
    PlayerScript playerScript;
    CharcterSelectMenu characterSelectMenu;


    public string Menu;

    public bool stopScore;
    public bool isAlive;

    public GameObject Coins;
    public GameObject GameOver;
    public GameObject Running;

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

        /*if (playerScript.isAlive == true)
        {
            GameOver.SetActive(false);
            Running.SetActive(true);
        }*/
    }

    public void Quit()
    {
        //ScoreCounter = GameObject.FindGameObjectWithTag("CoinCounter");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        StartCoroutine(MoveScoreToMenu());
        stopScore = true;

        //string currentSceneName = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(currentSceneName);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }

    public void DeadRetry()
    {

    }

    public void DeadMenu()
    {
        StartCoroutine(MoveScoreToMenu());
    }

    IEnumerator MoveScoreToMenu()
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
}