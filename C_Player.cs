using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Player : MonoBehaviour
{
    //global variables
    public float movementSpeed = 1.0f;
    float currentVerticalInput;
    Vector2 originalPosition;

    [SerializeField] KeyCode upKeyCode, downKeyCode, resetKeyCode;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentVerticalInput = GetVerticalInput();
        /*if (Input.GetKey(resetKeyCode))
            Reset();*/
    }

    void FixedUpdate()
    {
        Move(currentVerticalInput);
    }

    float GetVerticalInput() 
    {
        float currentInput = 0.0f;

        if (Input.GetKey(upKeyCode))
            currentInput = 1.0f;
        else if (Input.GetKey(downKeyCode))
            currentInput = -1.0f;
        
        return currentInput;
    }

    void Move(float verticalInput) 
    {
        float newXPosition = gameObject.transform.position.x;
        float newYPosition = gameObject.transform.position.y + verticalInput*movementSpeed;

        gameObject.transform.position = new Vector2(newXPosition, newYPosition);
    }

    public void Reset() 
    {
        gameObject.transform.position = originalPosition;
    }
}
