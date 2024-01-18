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
    public GameObject Score;
    

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

        Destroy(GameObject.FindWithTag("Player"));

        SceneManager.LoadScene(Menu, LoadSceneMode.Additive);

        SceneManager.MoveGameObjectToScene(GameObject.FindWithTag("Coins"), SceneManager.GetSceneByName(Menu));

        

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        //StartCoroutine(ReturnToMenu());
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

        Destroy(GameObject.FindWithTag("Player"));
        

        GameObject CurrentPlayer = GameObject.FindGameObjectWithTag("Player");

        Scene currentScene = SceneManager.GetActiveScene();

        isAlive = true;

        


        SceneManager.LoadScene(Menu);

      
        
        SceneManager.MoveGameObjectToScene(Coins, SceneManager.GetSceneByName(Menu));
        //SceneManager.MoveGameObjectToScene(CurrentPlayer, SceneManager.GetSceneByName(Menu));
        
        
        



        Time.timeScale = 1;

        //Destroy(GameObject.FindWithTag("Player"));

        SceneManager.UnloadScene(currentScene);
        //SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName(MangoMayhem));



        AsyncOperation asyncReLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);

        Instantiate(Coins);
        while (!asyncReLoad.isDone)
        {
            yield return null;
        }
    }

    

    IEnumerator ReLoadScene()
    {
        AsyncOperation asyncReLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);

        while (!asyncReLoad.isDone)
        {
            yield return null;
        }


    }
}