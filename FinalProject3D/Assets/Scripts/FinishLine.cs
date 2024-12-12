using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    //Script for the finish line at the end of the main course.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kevin")) SceneManager.LoadScene(3);
        if (collision.gameObject.CompareTag("Sammy")) SceneManager.LoadScene(4);
    }
}
