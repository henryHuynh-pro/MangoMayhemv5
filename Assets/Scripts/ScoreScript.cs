using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreScript : MonoBehaviour
{
    PlayerScript playerScript;
    RunButtons runButtons;
    CharcterSelectMenu characterSelectMenu;

    public TMP_Text coinText;
    public TMP_Text scoreText;
    public float score;
    public float coins;


    public bool MiguelLock;
    public bool HenryLock;
    public bool BrandonLock;
    public bool HansenLock;
    public bool NguyenLock;
    public bool JaxsonLock;
    public bool WyattLock;
    public bool CaelanLock;
    public bool ConnerLock;



    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        runButtons = GameObject.FindGameObjectWithTag("runButtons").GetComponent<RunButtons>();
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
        coins = characterSelectMenu.coins;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "COINS " + coins;
        
        
        coins = characterSelectMenu.coins;
        

        if(playerScript.coins >= coins)
        {
            coins = playerScript.coins;
        }

        if (playerScript.isAlive == true)
        {
           score += Time.deltaTime * 1 / 2;
           scoreText.text = "SCORE " + score.ToString("F");
           
        }
    }
}
