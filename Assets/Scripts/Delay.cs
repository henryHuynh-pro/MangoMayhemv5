using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    float DoubleJump = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoubleJumpDelay());
    }

    // Update is called once per frame
    private IEnumerator DoubleJumpDelay()
    {
        DoubleJump = 1;
        yield return new WaitForSeconds(1);
        DoubleJump = 2;
    }
}
