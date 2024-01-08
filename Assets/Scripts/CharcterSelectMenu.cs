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
    public GameObject HenryPlayer;
    public GameObject BrandonPlayer;
    public GameObject HansenPlayer;
    public GameObject NguyenPlayer;
    public GameObject JaxsonPlayer;
    public GameObject WyattPlayer;
    public GameObject CaelanPlayer;
    public GameObject ConnerPlayer;

    //Player Locks
    public Image MiguelLockImg;
    public Image HenryLockImg;
    public Image BrandonLockImg;
    public Image HansenLockImg;
    public Image NguyenLockImg;
    public Image JaxsonLockImg;
    public Image WyattLockImg;
    public Image CaelanLockImg;
    public Image ConnerLockImg;

    //Character Lock
    public bool MiguelLock;
    public bool HenryLock;
    public bool BrandonLock;
    public bool HansenLock;
    public bool NguyenLock;
    public bool JaxsonLock;
    public bool WyattLock;
    public bool CaelanLock;
    public bool ConnerLock;

    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Coins").GetComponent<ScoreScript>();
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

        //Lock All Skins



        HenryLock = true;
        BrandonLock = true;
        HansenLock = true;
        NguyenLock = true;
        JaxsonLock = true;
        WyattLock = true;
        MiguelLock = true;
        CaelanLock = true;
        ConnerLock = true;

        //Lock All Images
        MiguelLockImg.enabled = true;
        HenryLockImg.enabled = true;
        BrandonLockImg.enabled = true;
        HansenLockImg.enabled = true;
        NguyenLockImg.enabled = true;
        JaxsonLockImg.enabled = true;
        WyattLockImg.enabled = true;
        CaelanLockImg.enabled = true;
        ConnerLockImg.enabled = true;

        coins = playerScript.coins;

        
    }

    


    //Miguel Loader
    public void PlayMiguel()
    {
        if (MiguelLock == false)
        {
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
        if (HenryLock == false)
        {
            StartCoroutine(LoadSceneWithHenry());

        }

        if (coins >= 1 && HenryLock == true)
        {

            coins--;
            HenryLock = false;
            Debug.Log("purchase success!");
            playerScript.coins = coins;
            scoreScript.coins = coins;
            HenryLockImg.enabled = false;

        }
        else
        {
            Debug.Log("not enough coins or already bought");

        }

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
        if (BrandonLock == false)
        {
            StartCoroutine(LoadSceneWithBrandon());
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
        if (HansenLock == false)
        {
            StartCoroutine(LoadSceneWithHansen());
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
        if (NguyenLock == false)
        {
            StartCoroutine(LoadSceneWithNguyen());
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
        if (JaxsonLock == false)
        {
            StartCoroutine(LoadSceneWithJaxson());
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
        SceneManager.MoveGameObjectToScene(JaxsonPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(JaxsonPlayer);
        Instantiate(Score);
    }

    public void PlayCaelan()
    {
        if (CaelanLock == false)
        {
            StartCoroutine(LoadSceneWithCaelan());
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
        SceneManager.MoveGameObjectToScene(CaelanPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(CaelanPlayer);
        Instantiate(Score);
    }

    public void PlayWyatt()
    {
        if (WyattLock == false)
        {
            StartCoroutine(LoadSceneWithWyatt());
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
        SceneManager.MoveGameObjectToScene(WyattPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(WyattPlayer);
        Instantiate(Score);
    }

    public void PlayConner()
    {
        if (ConnerLock == false)
        {
            StartCoroutine(LoadSceneWithConner());
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
        SceneManager.MoveGameObjectToScene(ConnerPlayer, SceneManager.GetSceneByName(MangoMayhem));
        SceneManager.MoveGameObjectToScene(Score, SceneManager.GetSceneByName(MangoMayhem));

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        Instantiate(ConnerPlayer);
        Instantiate(Score);
    }
}
