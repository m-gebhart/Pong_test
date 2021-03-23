using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Ball: CircleCollider2D(isTrigger) + Rigidbody2D(Dynamic)
 */

public class Collider : MonoBehaviour
{
    enum FlipDirection {Horizontal, Vertical};
    [SerializeField] FlipDirection FlipDirectionFor;

    //GameObject should have Collider2D is Trigger
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (FlipDirectionFor == FlipDirection.Horizontal)
                collision.gameObject.GetComponent<C_Ball>().ChangeXDirection();
            else if (FlipDirectionFor == FlipDirection.Vertical)
                collision.gameObject.GetComponent<C_Ball>().ChangeYDirection();
        }
    }
}
