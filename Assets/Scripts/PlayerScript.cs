using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public float CurrentJumpValue = 1;
    public float JumpValue;
    public float Jumpforce;
    public float score;
    public float coins;
    public bool OnGround;
    public bool isAlive;
    public bool collectedCoin;

    Animator anim;

    [SerializeField]
    Rigidbody2D RB;

    

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Grounded", true);
        isAlive = true;
        collectedCoin = false;
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;


    }
    // Update is called once per frame

    

    private void Update()
    {
        

        //Reset Jump Value and Run Anim
        if (OnGround == true)
        {
            CurrentJumpValue = JumpValue;
            //Debug.Log("Running");
            anim.SetBool("Grounded", true);
        }

        if (Input.GetKeyDown(KeyCode.W) && CurrentJumpValue > 0)
        {
            RB.velocity = Vector2.up * Jumpforce;
            CurrentJumpValue --;
            OnGround = false;
            //Debug.Log("Jumping");
            anim.SetBool("Grounded", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && CurrentJumpValue > 0)
        {
            RB.velocity = Vector2.up * Jumpforce;
            CurrentJumpValue--;
            OnGround = false;
           // Debug.Log("Jumping");
            anim.SetBool("Grounded", false);
        }

        if (isAlive)
        {
           
           
          // Debug.Log("SCORE:" + score.ToString("F"));
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

        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(GameObject.FindWithTag("Coin"));
            collectedCoin = true;
            StartCoroutine(WaitOneSec());
            collectedCoin = false;
            
        }
    }

    IEnumerator WaitOneSec()
    {
        yield return new WaitForSeconds(1);
    }
}
