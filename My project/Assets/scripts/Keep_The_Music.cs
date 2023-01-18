using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep_The_Music : MonoBehaviour
{
    public Keep_The_Music music;

    void Awake()
    {
        if (music == null)
        {
            music = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    

}