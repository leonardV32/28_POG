using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToQuit()
    {
        SceneManager.LoadScene("Quit");
    }
}
