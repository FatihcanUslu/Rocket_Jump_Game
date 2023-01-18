using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{

    
    [Header("UIButtons")]
    public GameObject mainScreen;
    public Button devamEtButton;
    //public GameObject gameScreen;  //oyun sahnesi ekleyince aktif et

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        devamEtButton.enabled = PlayerPrefs.HasKey("savedLevel");
    }



    public void YeniOyun()
    {
        // yeni oyuna baþla
        PlayerPrefs.DeleteKey("savedLevel");
        SceneManager.LoadScene("SampleScene");
        //mainScreen.SetActive(false);
    }


    
    public void DevamEt()
    {
        // kaydedilmiþ oyun varmý diye kontrol et
        if (PlayerPrefs.HasKey("savedLevel"))
        {
            // son kaydolan levelin indexini kaydet
            int savedLevelIndex = PlayerPrefs.GetInt("savedLevel");

            // son kaydedilen leveli yükle
            SceneManager.LoadScene(savedLevelIndex);
        }
        else
        {
            // kaydedilmiþ oyun yoksa ekrana  mesaj ver
            Debug.Log("No save data found.");

        }
    }

    public void AnaMenuDon()
    {
        SceneManager.LoadScene("RocketJump");
    }
}