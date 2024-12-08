using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammyCylinder : MonoBehaviour
{
    public float voteReceived;
    public float speedPerVote = 0.01f;
    public float baseSpeed = 1.0f;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);
    public KeyCode voteKey = KeyCode.W;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement code
        bool voteKeyPressed;

        voteKeyPressed = Input.GetKeyDown(voteKey);

        if (voteKeyPressed)
        {
            voteReceived += 0.1f;
        }

        float moveStep = (baseSpeed + voteReceived + speedPerVote) * Time.deltaTime;

        transform.position = transform.position + movementDirection * moveStep;
    }
}

//add a speed limit of 8, side to side movement, and s as a slow down or stop button.