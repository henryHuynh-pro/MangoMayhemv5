using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score;
    PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        playerScript = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * 1 / 2;
        scoreText.text = "score " + score.ToString("F");

    }
}
