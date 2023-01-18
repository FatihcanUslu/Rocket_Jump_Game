using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_next_scene : MonoBehaviour
{
    public int currentscenenumber;
    private void Start()
    {
        currentscenenumber=SceneManager.GetActiveScene().buildIndex;
    }
    
    
    public void GoNextLevel()
    {
        Debug.Log("Current scene number: "+currentscenenumber);
        SceneManager.LoadScene(currentscenenumber + 1);
    }

}
