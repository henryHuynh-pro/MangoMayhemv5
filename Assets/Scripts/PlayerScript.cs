using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public float Jumpforce;
    float score;
    

    [SerializeField]
    bool isGrounded = true;
    //float isGrounded = 1;
    bool isAlive = true;
    bool jumpKeyHeld = true;
    bool isJumping = false;
    Vector2 counterJumpForce;


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
        public static float CalculateJumpForce(float gravityStrength, float jumpHeight)
        {
            //h = v^2/2g
            //2gh = v^2
            //sqrt(2gh) = v
            return Mathf.Sqrt(2 * gravityStrength * jumpHeight);
        }


        jumpForce = CalculateJumpForce(Physics2D.gravity.magnitude, 5.0f);

        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpKeyHeld = true;
            if (isGrounded)
            {
                isJumping = true;
                RB.AddForce(Vector2.up * jumpForce * RB.mass, ForceMode2D.Impulse);
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {
            jumpKeyHeld = false;
        }

        // In FixedUpdate()
        if (isJumping)
        {
            if (!jumpKeyHeld && Vector2.Dot(RB.velocity, Vector2.up) > 0)
            {
                RB.AddForce(counterJumpForce * RB.mass);
            }
        }
    }


    /*private void Update()
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
                score += Time.deltaTime * 4;
                ScoreTxt.text = "SCORE:" + score.ToString("F");
            
        }
    } */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }


            /*if (isGrounded == 2)
            {
                isGrounded = 1;
            }  */
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
