using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    CharcterSelectMenu characterSelectMenu;

    public float CurrentJumpValue = 1;
    public float JumpValue;
    public float Jumpforce;
    public float score;
    public float coins;
    public float checkJump;
    public bool OnGround;
    public bool isAlive;
    public bool collectedCoin;
    public bool usedFirstJump;

    Animator anim;

    [SerializeField]
    Rigidbody2D RB;

    

    void Start()
    {
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
        anim = GetComponent<Animator>();
        anim.SetBool("Grounded", true);
        anim.SetInteger("Height", 0);
        isAlive = true;
        collectedCoin = false;
        usedFirstJump = false;
        checkJump = JumpValue - 1;
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;


    }
    // Update is called once per frame
    

    private void Update()
    {
        if (coins <= characterSelectMenu.coins)
        {
            coins = characterSelectMenu.coins;
        }

        //Reset Jump Value and Run Anim
        if (OnGround == true)
        {
            usedFirstJump = false;
            CurrentJumpValue = JumpValue;
            //Debug.Log("Running");
            anim.SetInteger("Height", 0);
            anim.SetBool("Grounded", true);
        }

        if (OnGround == false && CurrentJumpValue <= checkJump && CurrentJumpValue > 0 && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            RB.velocity = Vector2.up * Jumpforce;
            CurrentJumpValue--;
            usedFirstJump = false;
            //Debug.Log("Double Jump");
            anim.SetBool("Grounded", false);
            anim.SetInteger("Height", 2);
            OnGround = false;

        }

        if (OnGround == true && CurrentJumpValue > checkJump && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            RB.velocity = Vector2.up * Jumpforce;
            usedFirstJump = true;
            //Debug.Log("First Jump");
            anim.SetBool("Grounded", false);
            anim.SetInteger("Height", 1);
            OnGround = false;
            CurrentJumpValue = JumpValue - 1;

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
