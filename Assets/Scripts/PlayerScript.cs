using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public float Jumpforce;
    float score;

    [SerializeField]
    float isGrounded = 1;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;
    private int extraJump;
    public int extraJumpValue;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;

    }
    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded == 1)
            {
                extraJump = extraJumpValue;
            }
            if (Input.GetKey(KeyCode.W) && isGrounded == 1)
            {
                RB.velocity = Vector2.up * Jumpforce;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
            {
                RB.velocity = Vector2.up * Jumpforce;

                extraJump--;
            }
        }

            if (isAlive)
            {
                score += Time.deltaTime * 2;
               ScoreTxt.text = "SCORE:" + score.ToString("F");
            
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
}
