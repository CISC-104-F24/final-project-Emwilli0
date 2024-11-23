using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KevinCube : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float jumpPower = 6f;
    Vector3 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {  //movement code
            bool upPressed = Input.GetKey(KeyCode.UpArrow);
            if (upPressed)
            {
                transform.position = transform.position + movementDirection.normalized + Vector3.forward * moveSpeed * Time.deltaTime;
            }

            bool downPressed = Input.GetKey(KeyCode.DownArrow);
            if (downPressed)
            {
                transform.position = transform.position + movementDirection.normalized + Vector3.back * moveSpeed * Time.deltaTime;
            }

            bool rightPressed = Input.GetKey(KeyCode.RightArrow);
            if (rightPressed)
            {
                transform.position = transform.position + movementDirection.normalized + Vector3.right * moveSpeed * Time.deltaTime;
            }

            bool leftPressed = Input.GetKey(KeyCode.LeftArrow);
            if (leftPressed)
            {
                transform.position = transform.position + movementDirection.normalized + Vector3.left * moveSpeed * Time.deltaTime;
            }

            //jump code
            bool jumpPowerPressed = Input.GetKeyDown(KeyCode.Space);
            if (jumpPowerPressed)
            {
                Rigidbody myRb = GetComponent<Rigidbody>();
                myRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }

            //jump cooldown code

            {

            }
        }
    }
}
