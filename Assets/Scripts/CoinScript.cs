using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public CoinGenerator CoinGenerator;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * CoinGenerator.currentSpeed * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            CoinGenerator.GenerateNextCoinWithtGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
