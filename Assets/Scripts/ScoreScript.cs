using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreScript : MonoBehaviour
{
    PlayerScript playerScript;

    public TMP_Text scoreText;
    public float score;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.isAlive == true)
        {
            score += Time.deltaTime * 1 / 2;
            scoreText.text = "score " + score.ToString("F");
        }
    }
}
