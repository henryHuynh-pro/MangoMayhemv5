using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public float Jumpforce;
    public float DoubleJumpforce;
    float score;

    [SerializeField]
    float isGrounded = 1;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded == 1)
            {
                RB.AddForce(Vector2.up * Jumpforce);
                isGrounded = 2;
                StartCoroutine(DoubleJumpDelay());

                if (Input.GetKeyDown(KeyCode.W))
                {

                    if (isGrounded == 2)
                    {
                        RB.AddForce(Vector2.up * DoubleJumpforce);
                        isGrounded = 2;
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
            if (isGrounded == 2)
            {
                isGrounded = 1;
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

    private IEnumerator DoubleJumpDelay()
    {
        yield return new WaitForSeconds(0.005F);
        
    }
}
