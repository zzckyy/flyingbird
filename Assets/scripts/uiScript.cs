using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiScript : MonoBehaviour
{
    public void PauseGame(GameObject PauseUI){
        Time.timeScale = 0;
        PauseUI.SetActive(true);
    }

    public void ResumeGame(GameObject PauseUI){
        Time.timeScale = 1;
        PauseUI.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void RestartLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
