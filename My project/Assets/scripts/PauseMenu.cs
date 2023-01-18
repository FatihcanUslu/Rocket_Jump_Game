using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private static bool  GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Start()
    {
        PauseMenuUI.GetComponent<Canvas>().enabled=false;
    }
    void FixedUpdate()
    {
        //float Escape=Input.GetAxis("Cancel");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        
         if(GameIsPaused){
             Resume();
             }
             
         else{
             Pause();
             }
        GameIsPaused = !GameIsPaused;
         
     }
            
    }

void Resume(){
    PauseMenuUI.GetComponent<Canvas>().enabled=false;
    Time.timeScale = 1f;
    GameIsPaused= false;
}
void Pause()
{
    PauseMenuUI.GetComponent<Canvas>().enabled=true;
    Time.timeScale = 0.5f;
    GameIsPaused = true;
}
 public void Restart(){ 

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }

public void QuitGame(){
    Debug.Log("Quitting Game...");
}
}
