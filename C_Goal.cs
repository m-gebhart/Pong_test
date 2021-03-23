using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Goal : MonoBehaviour
{
    enum ScoreForPlayer { PlayerOne, PlayerTwo };
    [SerializeField] ScoreForPlayer ScoreFor;

    //GameObject should have Collider2D is Trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (ScoreFor == ScoreForPlayer.PlayerOne)
                GameManager.p1score++;
            else if (ScoreFor == ScoreForPlayer.PlayerTwo)
                GameManager.p2score++;
            GameObject manager = GameObject.Find("/GameManager");
            if (manager != null)
                manager.GetComponent<GameManager>().Reset();
            Debug.Log("Score: "+ GameManager.p1score + " : "+ GameManager.p2score);
        }
    }
}
