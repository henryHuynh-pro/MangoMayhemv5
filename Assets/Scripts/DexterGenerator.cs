using UnityEngine;

public class DexterGenerator : MonoBehaviour
{   
    public GameObject Dexter;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        GenerateDexter();
    }

    public void GenerateNextDexterWithtGap()
    {
        float v = Random.Range(0.2f, 2.2f);
        Invoke("GenerateDexter", v);
    }

    void GenerateDexter()
    {
        GameObject DexterIns = Instantiate(Dexter, transform.position, transform.rotation);

        DexterIns.GetComponent<DexterScript>().DexterGenerator = this;

    }
    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
