using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player1, player2, ball;
    bool bGameOver;

    public static int p1score, p2score;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            Reset();
    }

    public void Reset() 
    {
        player1.GetComponent<C_Player>().Reset();
        player2.GetComponent<C_Player>().Reset();
        ball.GetComponent<C_Ball>().Reset();
    }
}
