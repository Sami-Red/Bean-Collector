using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }  
        }
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
      {
        pauseMenuUI.SetActive(false);
        // settingMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
      }         
   /* public void BackToMainMenu(){
        SceneManager.LoadScene(MainMenu);
    } */
    public void QuitGame()
    {
        print("How could you...");
        print("I don't want you to leave");
        Application.Quit();
    }
}
