using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pausePanel;
    bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResume();
        }
    }

    public void PauseOrResume()
    {
        if(isPaused)
        {
            isPaused = false;
            pausePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else
        {
            isPaused = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
