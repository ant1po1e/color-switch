using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject failPanel;

    public float slowness = 10f;

    public void GameOver()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        PlayFailSound();
        PauseMenu.instance.isFail = true;
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(2f / slowness);

        failPanel.SetActive(true);
        Time.timeScale = 0f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
    }

    public void PlayFailSound()
    {
        SoundManager.instance.PlayAudio(SoundManager.instance.gameOver);
    }
}
