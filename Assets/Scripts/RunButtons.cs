using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunButtons : MonoBehaviour
{
    public string Menu;

    public GameObject CoinCounter;
    public void Quit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Destroy(GameObject.FindWithTag("Player"));
        SceneManager.MoveGameObjectToScene(CoinCounter, SceneManager.GetSceneByName(Menu));
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}