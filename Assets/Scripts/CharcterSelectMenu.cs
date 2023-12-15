using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharcterSelectMenu : MonoBehaviour
{
    //Game
    ScoreScript scoreScript;

    public string MangoMayhem;

    public GameObject Score;

    public float coins;
    

    //Players For Run Game
    public GameObject MiguelPlayer;
    public GameObject HenryPlayer;
    public GameObject BrandonPlayer;
    public GameObject HansenPlayer;
    public GameObject NguyenPlayer;
    public GameObject JaxsonPlayer;
    public GameObject WyattPlayer;

    //Character Lock
    public bool MiguelLock;
    public bool HenryLock;
    public bool BrandonLock;
    public bool HansenLock;
    public bool NguyenLock;
    public bool JaxsonLock;
    public bool WyattLock;
    public bool purchase;

    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Coins").GetComponent<ScoreScript>();

        //Lock All Skins
        HenryLock = true;
        BrandonLock = true;
        HansenLock = true;
        NguyenLock = true;
        JaxsonLock = true;
        WyattLock = true;
        MiguelLock = true;

        coins = scoreScript.coins;
    }

    void Update()
    {
        
        
        
    }



    //Miguel Loader
    public void PlayMiguel()
    {
        

        if (MiguelLock == false)
        {
            StartCoroutine(LoadSceneWithMiguel());
            
        }

        if (coins >= 1 && MiguelLock == true)
        {
           
            scoreScript.coins -= 1;
            MiguelLock = false;
            purchase = true;
            Debug.Log("purchase success!");
            //scoreScript.coins = coins;
        } else
        {
            Debug.Log("not enough coins or already bought");
            
        }

        coins = scoreScript.coins;
    }

    IEnumerator LoadSceneWithMiguel()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(MiguelPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(MiguelPlayer);
        Instantiate(Score);
    }

    //Henry Loader
    public void PlayHenry()
    {
        StartCoroutine(LoadSceneWithHenry());

    }

    IEnumerator LoadSceneWithHenry()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(HenryPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(HenryPlayer);
        Instantiate(Score);
    }


    //Brandon Loader
    public void PlayBrandon()
    {
        StartCoroutine(LoadSceneWithBrandon());

    }

    IEnumerator LoadSceneWithBrandon()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(BrandonPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(BrandonPlayer);
        Instantiate(Score);

    }

    public void PlayHansen()
    {
        StartCoroutine(LoadSceneWithHansen());

    }

    IEnumerator LoadSceneWithHansen()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(HansenPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(HansenPlayer);
        Instantiate(Score);
    }

    public void PlayNguyen()
    {
        StartCoroutine(LoadSceneWithNguyen());

    }

    IEnumerator LoadSceneWithNguyen()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(NguyenPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(NguyenPlayer);
        Instantiate(Score);
    }

    public void PlayJaxson()
    {
        StartCoroutine(LoadSceneWithJaxson());

    }

    IEnumerator LoadSceneWithJaxson()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(JaxsonPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(JaxsonPlayer);
        Instantiate(Score);
    }

    public void PlayWyatt()
    {
        StartCoroutine(LoadSceneWithWyatt());

    }

    IEnumerator LoadSceneWithWyatt()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MangoMayhem, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(WyattPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(WyattPlayer);
        Instantiate(Score);
    }
}
