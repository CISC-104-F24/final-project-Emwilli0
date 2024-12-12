using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammyCylinder : MonoBehaviour
{
    public float voteReceived;
    public float moveSpeed = 1f;
    public float speedPerVote = 0.01f;
    public float baseSpeed = 1.0f;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);
    public KeyCode voteKey = KeyCode.W;

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

        if (voteReceived >= 2f)
        {
            voteReceived = 2f;
        }

        bool rightPressed = Input.GetKey(KeyCode.D);
        if (rightPressed)
        {
            transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;
        }

        bool leftPressed = Input.GetKey(KeyCode.A);
        if (leftPressed)
        {
            transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        }

        bool slowDown = Input.GetKeyDown(KeyCode.S);
        if (slowDown)
        {
            voteReceived = voteReceived - 0.1f;
        }

    }
    private void OnTriggerEnter()
    {
        if (CompareTag("Sammy")) Debug.Log("Sammy has made it halfway!");
    }

}