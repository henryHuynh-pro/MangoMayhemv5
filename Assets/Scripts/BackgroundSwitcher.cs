using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class BackgroundSwitcher : MonoBehaviour
{
    public GameObject BackgroundA;
    public GameObject BackgroundB;
    public GameObject BackgroundC;
    public GameObject BackgroundD;


    // Start is called before the first frame update
    public void Awake()
    {
        BackgroundA.SetActive(false);
        BackgroundB.SetActive(false);
        BackgroundC.SetActive(false);
        BackgroundD.SetActive(false);


            int x = Random.Range(0, 3);

            if (x == 0)
            {
                BackgroundA.SetActive(true);

            }

            if (x == 1)
            {
                BackgroundB.SetActive(true);
            }

            if (x == 2)
            {
                BackgroundC.SetActive(true);
            }

        if (x == 3)
        {
            BackgroundD.SetActive(true);
        }
    }
}
