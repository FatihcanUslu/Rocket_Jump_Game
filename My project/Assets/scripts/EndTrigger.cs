using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Go_next_scene go_next_scene;
    public float DelayTime=3f;

    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Player")
     {
        gameManager.CompleteLevel();
        go_next_scene.Invoke("GoNextLevel",DelayTime);
        
     }
        
    }
}
