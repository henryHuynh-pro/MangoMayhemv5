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
    public bool test;

    public GameObject Coins;
    public GameObject GameOver;
    public GameObject Running;

    public int CurrentPlayer;

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
        //SceneManager.Load(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        StartCoroutine(ReturnToMenu());
        stopScore = true;
    }

    public void Retry()
    {
        //CurrentPlayer = GameObject.FindGameObjectWithTag("Player").GetHashCode();

        //Debug.Log(CurrentPlayer);
        isAlive = true;
        playerScript.isAlive = true;

        GameOver.SetActive(false);
        Running.SetActive(true);

        test = true;
        //playerScript.isAlive = true;
        Invoke("Invinciblility", 2);



    }

    IEnumerator ReturnToMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        
        

        Scene currentScene = SceneManager.GetActiveScene();

        isAlive = true;

        


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Menu, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        //Destroy(GameObject.FindWithTag("Player"));

        //SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));
        SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));

        Time.timeScale = 1;

        //Destroy(GameObject.FindWithTag("Player"));

        //SceneManager.UnloadSceneAsync(currentScene);
        SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName(MangoMayhem));


        Instantiate(Coins);

    }

    

    IEnumerator FunkyThing()
    {
        //Scene currentScene = SceneManager.GetActiveScene();

        isAlive = true;


        //SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("Player"), SceneManager.GetSceneByName(MangoMayhem));
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);


        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        //SceneManager.MoveGameObjectToScene(CurrentPlayer, SceneManager.GetSceneByName(MangoMayhem));


        Time.timeScale = 1;

        //Destroy(GameObject.FindWithTag("Player"));

        //SceneManager.UnloadSceneAsync(currentScene);

        

    }
}