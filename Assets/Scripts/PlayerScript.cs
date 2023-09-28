using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Jumpforce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D RB;


    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * Jumpforce);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }
    }
}
