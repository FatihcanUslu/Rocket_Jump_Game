using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float DelayTime=3f;
    public GameObject completeLevelUI;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("savedLevel"))
        {
            PlayerPrefs.SetInt("savedLevel", SceneManager.GetActiveScene().buildIndex);
        }
        
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("savedLevel"))
        {
            PlayerPrefs.SetInt("savedLevel", SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Completed !!!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded=true;
            Debug.Log("game over!!!");
            
            //invoke  gecikmeli çağrılarda kullanılır
            Invoke("Restart",DelayTime);
        }
        
    }
    //o esnada aktif olan scene adını al ve bu scene'i yeniden yükle
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
