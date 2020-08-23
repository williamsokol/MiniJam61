using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public bool soundMute;
    public Text MuteText;
    void Start()
    {
        soundMute = false;
        MuteText.text = "Mute";
    }

    public void Play()
    {
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
        if (soundMute == false)
        {
            AudioListener.volume = 0f;
            soundMute = true;
            MuteText.text = "Unmute";
        }
        else
        {
            AudioListener.volume = 1f;
            soundMute = false;
            MuteText.text = "Mute";
        }
    }
}
