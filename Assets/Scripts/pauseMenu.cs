using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
        }

        if (isPaused){
            ActivateMenu();
        }

        else{
            DeactivateMenu();
        }
    }

    public void isPauseTrue(bool pause){
        isPaused = pause;
    }
    void ActivateMenu(){
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    void DeactivateMenu(){
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
    }
}
