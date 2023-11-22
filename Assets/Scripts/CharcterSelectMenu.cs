using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharcterSelectMenu : MonoBehaviour
{
    //Game
    public string MangoMayhem;

    public GameObject Score;

    //Players For Run Game
    public GameObject MiguelPlayer;
    public GameObject HenryPlayer;
    public GameObject BrandonPlayer;
    public GameObject HansenPlayer;



    //Miguel Loader
    public void PlayMiguel()
    {
        StartCoroutine(LoadSceneWithMiguel());
        
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

}
