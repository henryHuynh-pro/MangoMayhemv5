using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharcterSelectMenu : MonoBehaviour
{
    //Game
    public string MangoMayhem;

    //Players For Run Game
    public GameObject MiguelPlayer;
    public GameObject HenryPlayer;
    public GameObject BrandonPlayer;

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

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        GameObject newInstance = Instantiate(MiguelPlayer);
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

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        GameObject newInstance = Instantiate(HenryPlayer);
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

        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

        // Instantiates the Prefab as a GameObject
        GameObject newInstance = Instantiate(BrandonPlayer);
    }
}
