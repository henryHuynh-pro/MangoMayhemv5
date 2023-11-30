using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreScript : MonoBehaviour
{
    PlayerScript playerScript;

    public TMP_Text coinText;
    public TMP_Text scoreText;
    public float score;
    public float coins;

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        coins = playerScript.coins;

        if (playerScript.isAlive == true)
        {
           score += Time.deltaTime * 1 / 2;
           scoreText.text = "SCORE " + score.ToString("F");
           
        }

        coinText.text = "COINS " + coins;
    }
}
