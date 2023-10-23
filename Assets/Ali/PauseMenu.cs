using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public GameObject PausePanel;


    private void Start()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        Pause();
    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }  
    }

    public void ButtonPause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}