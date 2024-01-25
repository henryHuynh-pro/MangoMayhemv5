using UnityEngine;

public class CoinGenerator : MonoBehaviour
{   
    public GameObject Coin;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        GenerateCoin();
    }

    public void GenerateNextCoinWithtGap()
    {
        float v = Random.Range(7.2f, 10.2f);
        Invoke("GenerateCoin", v);
    }

    void GenerateCoin()
    {
        var position = new Vector3(32, Random.Range(5, 9), 0);
        GameObject CoinIns = Instantiate(Coin, position, Quaternion.identity);


        CoinIns.GetComponent<CoinScript>().CoinGenerator = this;

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
