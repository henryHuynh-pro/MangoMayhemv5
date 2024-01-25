using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    CharcterSelectMenu characterSelectMenu;
    RunButtons runButtons;

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
    public bool test;

    Animator anim;

    [SerializeField]
    Rigidbody2D RB;

    

    void Start()
    {
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
        runButtons = GameObject.FindGameObjectWithTag("runButtons").GetComponent<RunButtons>();

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
        


    }
    // Update is called once per frame
    

    private void Update()
    {
        if (coins <= characterSelectMenu.coins)
        {
            coins = characterSelectMenu.coins;
        }

        //Reset Jump Value and Run Anim
        if (OnGround == true && isAlive == true)
        {
            usedFirstJump = false;
            CurrentJumpValue = JumpValue;
        }

        if (OnGround == false && CurrentJumpValue <= checkJump && CurrentJumpValue > 0 && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            RB.velocity = Vector2.up * Jumpforce;
            CurrentJumpValue--;
            usedFirstJump = false;
            anim.SetBool("Grounded", false);
            OnGround = false;

        }

        if (OnGround == true && CurrentJumpValue > checkJump && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            RB.velocity = Vector2.up * Jumpforce;
            usedFirstJump = true;
            anim.SetBool("Grounded", false);
            OnGround = false;
            CurrentJumpValue = JumpValue - 1;

        }

        
        if (isAlive)
        {
            runButtons.isAlive = true;
        }

       
        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            OnGround = true;
            anim.SetBool("Grounded", true);
        }

        if (collision.gameObject.CompareTag("spike") && runButtons.test == false)
        {
            isAlive = false;
            runButtons.isAlive = false;

        }

        if (collision.gameObject.CompareTag("Dexter") && runButtons.test == false)
        {
            isAlive = false;
            runButtons.isAlive = false;
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
