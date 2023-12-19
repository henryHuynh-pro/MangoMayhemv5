using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{
    public string Menu;

    public bool stopScore;

    public GameObject Coins;


    void Start()
    {
        stopScore = false;
    }

    public void Quit()
    {
        //ScoreCounter = GameObject.FindGameObjectWithTag("CoinCounter");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        StartCoroutine(MoveScoreToMenu());
        stopScore = true;
        
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }


    IEnumerator MoveScoreToMenu()
    {
        Scene currentScene = SceneManager.GetActiveScene();



        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Menu, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }



        SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));
        Destroy(GameObject.FindWithTag("Player"));

        SceneManager.UnloadSceneAsync(currentScene);

        Instantiate(Coins);

    }
}