using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool  GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if(Input.GetAxis("Submit")){
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

void Resume(){
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused= false;
}
void Pause()
{
    PauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
}
 public void Restart(){ 

    SceneManagener.LoadScene(SceneManagener.GetActiveScene(),name);
 }

public void QuitGame(){
    Debug.Log("Quitting Game...");
}
}
