using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    //Script for the Back to Title UI
    public void LoadTitle()
    {
        SceneManager.LoadScene(0);
    }

}
