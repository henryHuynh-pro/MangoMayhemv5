using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public float CurrentJumpValue = 1;
    public float JumpValue;
    public float Jumpforce;
    public float score;
    public bool OnGround;


    public Animator animator;
    bool Grounded;

    [SerializeField]
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Grounded = true;
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
        animator = GetComponent<Animator>();

    }
    // Update is called once per frame

    
    private void Update()
    {

        //Reset Jump Value and Run Anim
        if (OnGround == true)
        {
            CurrentJumpValue = JumpValue;
            Debug.Log("Running");
            Grounded = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && CurrentJumpValue > 0)
        {
            RB.velocity = Vector2.up * Jumpforce;
            CurrentJumpValue --;
            OnGround = false;
            Debug.Log("Jumping");
            Grounded = false;
        }

        if (Grounded == false)
            animator.SetBool("Ground", false);

        if (Grounded == true)
            animator.SetBool("Ground", true);

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
            OnGround = true;
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
