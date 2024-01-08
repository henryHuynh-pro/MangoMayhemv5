using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitcher : MonoBehaviour
{
    public GameObject BackgroundA;
    public GameObject BackgroundB;
    public GameObject BackgroundC;
    public GameObject BackgroundD;


    // Start is called before the first frame update
    void Start()
    {
        for (; ; )
        {
            int x = Random.Range(0, 3);
            switch (x)
            {
                case 0:
                    Debug.Log("backgroundA");
                    break;
                case 1:
                    Debug.Log("backgroundB");
                    break;
                case 2:
                    Debug.Log("backgroundC");
                    break;
                case 3:
                    Debug.Log("backgroundD");
                    break;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
