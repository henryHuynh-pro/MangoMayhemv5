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

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        runButtons = GameObject.FindGameObjectWithTag("runButtons").GetComponent<RunButtons>();
        characterSelectMenu = GameObject.FindGameObjectWithTag("characterMenu").GetComponent<CharcterSelectMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterSelectMenu.purchase == true)
        {
            coins = characterSelectMenu.coins;
        }
        coins = playerScript.coins;

        if (playerScript.isAlive == true)
        {
           score += Time.deltaTime * 1 / 2;
           scoreText.text = "SCORE " + score.ToString("F");
           
        }

        coinText.text = "COINS " + coins;

    }
}
