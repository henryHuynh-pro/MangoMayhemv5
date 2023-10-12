using UnityEngine;

public class DexterScript : MonoBehaviour
{
    public DexterGenerator DexterGenerator;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * DexterGenerator.currentSpeed * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            DexterGenerator.GenerateNextDexterWithtGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
