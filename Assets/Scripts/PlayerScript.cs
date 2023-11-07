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
    public Animation Run;
    public Animation Jump;
    public bool animatePhysics;

    [SerializeField]
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;

    void Start()
    {
        Run = GetComponent<Animation>();
        foreach (AnimationState state in Run)
        {
            state.speed = 0.5F;
        }
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;

    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (CurrentJumpValue > 0)
            {
                RB.velocity = Vector2.up * Jumpforce;
                CurrentJumpValue --;
            }

        }
            
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
            CurrentJumpValue = JumpValue;
            
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
