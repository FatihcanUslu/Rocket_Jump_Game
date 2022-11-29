using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public player_movement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log("we hit "+collisionInfo.collider.name+ " brotha !!!");
        if(collisionInfo.collider.tag=="Obstacle")
        {
            Debug.Log("we hit that damn obstacle :(");
            GetComponent<player_movement>().enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }    
    }
    

}
