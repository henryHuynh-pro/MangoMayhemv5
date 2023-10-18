using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float Jumpforce;
    public float DoubleJumpforce;
    float score;


    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;
    public float time;
    public float timeDelay;


    void Start()
    {
        time = 0f;
        timeDelay = 1f;
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        time += 1f * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded == true)
            {
                RB.AddForce(Vector2.up * Jumpforce);
                isGrounded = false;

                if (time >= timeDelay)
                {
                    time = 0f;

                    if (isGrounded == false)
                    {
                        RB.AddForce(Vector2.up * DoubleJumpforce);
                        isGrounded = false;
                    }


                }
            }

            if (isAlive)
            {
                score += Time.deltaTime * 4;
                ScoreTxt.text = "SCORE:" + score.ToString("F");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }

        if (collision.gameObject.CompareTag("Dexter"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }
}
