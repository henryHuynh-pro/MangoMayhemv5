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

    public GameObject Coins;


    void Start()
    {
        stopScore = false;

        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
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


    IEnumerator MoveScoreToMenu()
    {
        Scene currentScene = SceneManager.GetActiveScene();


        SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Menu);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }



        //SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));

        

        //Destroy(GameObject.FindWithTag("Player"));

        SceneManager.UnloadSceneAsync(currentScene);

        Instantiate(Coins);

    }
}