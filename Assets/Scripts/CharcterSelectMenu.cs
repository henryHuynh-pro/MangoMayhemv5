using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class CharcterSelectMenu : MonoBehaviour
{
    //Game
    ScoreScript scoreScript;
    PlayerScript playerScript;


    public string MangoMayhem;

    public GameObject Score;

    public float coins;


    //Players For Run Game
    

    public GameObject MiguelPlayer;
    public GameObject BrandonPlayer;
    public GameObject HansenPlayer;
    public GameObject NguyenPlayer;
    public GameObject JaxsonPlayer;
    public GameObject WyattPlayer;
    public GameObject CaelanPlayer;
    public GameObject ConnerPlayer;
    public GameObject IraPlayer;
    public GameObject RobertPlayer;

    //Player Locks
    public Image MiguelLockImg;
    public Image BrandonLockImg;
    public Image HansenLockImg;
    public Image NguyenLockImg;
    public Image JaxsonLockImg;
    public Image WyattLockImg;
    public Image CaelanLockImg;
    public Image ConnerLockImg;
    public Image IraLockImg;
    public Image RobertLockImg;

    //Character Lock
    public bool MiguelLock;
    public bool BrandonLock;
    public bool HansenLock;
    public bool NguyenLock;
    public bool JaxsonLock;
    public bool WyattLock;
    public bool CaelanLock;
    public bool ConnerLock;
    public bool IraLock;
    public bool RobertLock;


    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Coins").GetComponent<ScoreScript>();
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

        //Lock All Skins
        BrandonLock = true;
        HansenLock = true;
        NguyenLock = true;
        JaxsonLock = true;
        WyattLock = true;
        MiguelLock = true;
        CaelanLock = true;
        ConnerLock = true;
        IraLock = true;
        RobertLock = true;

        //Lock All Images
        MiguelLockImg.enabled = true;
        BrandonLockImg.enabled = true;
        HansenLockImg.enabled = true;
        NguyenLockImg.enabled = true;
        JaxsonLockImg.enabled = true;
        WyattLockImg.enabled = true;
        CaelanLockImg.enabled = true;
        ConnerLockImg.enabled = true;
        IraLockImg.enabled = true;
        RobertLockImg.enabled = true;

        coins = playerScript.coins;

        
    }

    


    //Miguel Loader
    public void PlayMiguel()
    {
        if (MiguelLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithMiguel());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);

            

            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && MiguelLock == true)
        {
           
            coins--;
            MiguelLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            MiguelLockImg.enabled = false;
            scoreScript.MiguelLock = false;

        } else
        {
            Debug.Log("not enough coins or already bought");
            
        }
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
        

        PrefabUtility.InstantiatePrefab(MiguelPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
        

        // Instantiates the Prefab as a GameObject
        //Instantiate(MiguelPlayer);
        
        Instantiate(Score);
    }

    //Ira Loader
    public void PlayIra()
    {
        if (IraLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithIra());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && IraLock == true)
        {

            coins--;
            IraLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            IraLockImg.enabled = false;
            scoreScript.IraLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
    }

    IEnumerator LoadSceneWithIra()
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


        PrefabUtility.InstantiatePrefab(IraPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(IraPlayer);

        Instantiate(Score);
    }


    //Brandon Loader
    public void PlayBrandon()
    {
        if (BrandonLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithBrandon());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && BrandonLock == true)
        {

            coins--;
            BrandonLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            BrandonLockImg.enabled = false;
            scoreScript.BrandonLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
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


        PrefabUtility.InstantiatePrefab(BrandonPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(BrandonPlayer);

        Instantiate(Score);
    }

    //Hansen Loader
    public void PlayHansen()
    {
        if (HansenLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithHansen());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && HansenLock == true)
        {

            coins--;
            HansenLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            HansenLockImg.enabled = false;
            scoreScript.HansenLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
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


        PrefabUtility.InstantiatePrefab(HansenPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(HansenPlayer);

        Instantiate(Score);
    }

    //Nguyen Loader
    public void PlayNguyen()
    {
        if (NguyenLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithNguyen());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && NguyenLock == true)
        {

            coins--;
            NguyenLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            NguyenLockImg.enabled = false;
            scoreScript.NguyenLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
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


        PrefabUtility.InstantiatePrefab(NguyenPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(NguyenPlayer);

        Instantiate(Score);
    }

    //Jaxson Loader
    public void PlayJaxson()
    {
        if (JaxsonLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithJaxson());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && JaxsonLock == true)
        {

            coins--;
            JaxsonLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            JaxsonLockImg.enabled = false;
            scoreScript.JaxsonLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
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


        PrefabUtility.InstantiatePrefab(JaxsonPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(JaxsonPlayer);

        Instantiate(Score);
    }

    //Caelan Loader
    public void PlayCaelan()
    {
        if (CaelanLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithCaelan());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && CaelanLock == true)
        {

            coins--;
            CaelanLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            CaelanLockImg.enabled = false;
            scoreScript.CaelanLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
    }

    IEnumerator LoadSceneWithCaelan()
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


        PrefabUtility.InstantiatePrefab(CaelanPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(CaelanPlayer);

        Instantiate(Score);
    }

    //Wyatt Loader
    public void PlayWyatt()
    {
        if (WyattLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithWyatt());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && WyattLock == true)
        {

            coins--;
            WyattLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            WyattLockImg.enabled = false;
            scoreScript.WyattLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
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


        PrefabUtility.InstantiatePrefab(WyattPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(WyattPlayer);

        Instantiate(Score);
    }

    //Conner Loader
    public void PlayConner()
    {
        if (ConnerLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithConner());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);



            playerScript.isAlive = true;
            Time.timeScale = 1;

        }

        if (coins >= 1 && ConnerLock == true)
        {

            coins--;
            ConnerLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            ConnerLockImg.enabled = false;
            scoreScript.ConnerLock = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }
    }

    IEnumerator LoadSceneWithConner()
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


        PrefabUtility.InstantiatePrefab(ConnerPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(ConnerPlayer);

        Instantiate(Score);
    }

    //Robert Loader
    public void PlayRobert()
    {
        if (RobertLock == false)
        {
            scoreScript.PlayerSelected = 1;
            StartCoroutine(LoadSceneWithRobert());
            //string currentSceneName = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(currentSceneName);
        }
    }

    IEnumerator LoadSceneWithRobert()
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


        PrefabUtility.InstantiatePrefab(RobertPlayer, SceneManager.GetSceneByName(MangoMayhem));
        PrefabUtility.InstantiatePrefab(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);


        // Instantiates the Prefab as a GameObject
        //Instantiate(RobertPlayer);

        Instantiate(Score);
    }
}
