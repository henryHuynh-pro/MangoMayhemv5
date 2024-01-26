using UnityEngine;

public class BackgroundSwitcher : MonoBehaviour
{
    public GameObject BackgroundA;
    public GameObject BackgroundB;
    public GameObject BackgroundC;
    public GameObject BackgroundD;


    // Start is called before the first frame update
    public void Awake()
    {

        int x = Random.Range(0, 4);
        

        if (x == 0)
        {
            Instantiate(BackgroundA);
        }

        if (x == 1)
        {
            Instantiate(BackgroundB);
        }

        if (x == 2)
        {
            Instantiate(BackgroundC);
        }

        if (x == 3)
        {
            Instantiate(BackgroundD);
        }
    }
}
