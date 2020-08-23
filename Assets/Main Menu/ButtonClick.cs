using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public bool soundMute = false;
    public Text MuteText;

    public void Play()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        SceneManager.LoadScene("Game Level");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Mute()
    {
        if (!soundMute)
        {
            MuteText.text = "Unmute";
            AudioListener.volume = 0f;
            soundMute = true;
        }
        else
        {
            MuteText.text = "Mute";
            AudioListener.volume = 1f;
            soundMute = false;
        }
    }
}
