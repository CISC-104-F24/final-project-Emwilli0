using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
   //Script for the DeathPlane below the main course.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kevin")) SceneManager.LoadScene(4);
        if (collision.gameObject.CompareTag("Sammy")) SceneManager.LoadScene(3);
    }
}
