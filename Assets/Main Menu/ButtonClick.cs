using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game Level");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
