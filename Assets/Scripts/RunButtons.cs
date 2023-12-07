using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{
    public string Menu;

    public GameObject ScoreCounter;
    public void Quit()
    {
        //ScoreCounter = GameObject.FindGameObjectWithTag("CoinCounter");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        //StartCoroutine(MoveScoreToMenu());
        GameObject[] gos = GameObject.FindGameObjectsWithTag("CoinCounter");
        foreach (GameObject go in gos)
            Destroy(go);


    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }   

    IEnumerator MoveScoreToMenu()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();
        //ScoreCounter = GameObject.FindGameObjectWithTag("CoinCounter");

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        //SceneManager.MoveGameObjectToScene(go, SceneManager.GetSceneByName(Menu));
        //SceneManager.MoveGameObjectsToScene()

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        
        Instantiate(ScoreCounter);
    }
}