using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelPanel;

    void Start()
    {
        levelPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void PlayGame()
    {
        PlayButtonClickSound();
        levelPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void ToLevelOne()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene("Level_1");
    }

    public void ToLevelTwo()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene("Level_2");
    }

    public void ToLevelThree()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene("Level_3");
    }

    public void ToLevelFour()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene("Level_4");
    }

    public void ToLevelFive()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene("Level_5");
    }

    public void PlayClosed()
    {
        PlayButtonClickSound();
        levelPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void QuitGame()
    {
        PlayButtonClickSound();
        Application.Quit();
    }

    public void PlayButtonClickSound()
    {
        SoundManager.instance.PlayAudio(SoundManager.instance.buttonUI);
    }
}
