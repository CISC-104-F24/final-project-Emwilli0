using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryDance : MonoBehaviour
{
    //this is code so Kevin can jump on the podium when he wins. Sammy can't jump so he doesn't get this script.
    public float jumpPower = 6f;
    public float timeSinceJump = 0;
    public float jumpCooldown = 1.25f;
    void Update()
    {
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);

        if (timeSinceJump < jumpCooldown)
        {
            jumpPressed = false;
        }

        if (jumpPressed)
        {
            Rigidbody myRb = GetComponent<Rigidbody>();
            myRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            timeSinceJump = 0;
        }

        timeSinceJump += Time.deltaTime;
    }
}
