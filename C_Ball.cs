using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Ball : MonoBehaviour
{
    public float xMaxSpeed, yMaxSpeed;
    Vector2 currentMovement, originalPosition;

    [HideInInspector] public int xDirection;

    // Start is called before the first frame update
    void Start()
    {
        xDirection = 1;
        currentMovement = GetRandomMovementVector();
    }

    // Update is called once per frame
    void Update()
    {
        Move(currentMovement*Time.deltaTime);
    }

    void Move(Vector2 xyMovement)
    {
        gameObject.transform.position += new Vector3(xyMovement.x, xyMovement.y, 0.0f);
    }


    // STEP 4-5

    //called on collision with player
    public void ChangeXDirection()
    {
        xDirection = -xDirection;
        currentMovement = GetRandomMovementVector();
    }

    Vector2 GetRandomMovementVector()
    {
        float yMovement = Random.Range(-yMaxSpeed, yMaxSpeed);
        return new Vector2(xMaxSpeed * xDirection, yMovement);
    }

    //called on collision with top- / bottom frame
    public void ChangeYDirection()
    {
        currentMovement.y = -currentMovement.y;
    }

    public void Reset() 
    {
        gameObject.transform.position = originalPosition;
    }
}
