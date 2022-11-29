using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public Transform player;
    public float Sensitivity=2f;
    float cameraVerticalRotation=0f;
    bool CursorLocked=true;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputx=Input.GetAxis("Mouse X")*Sensitivity;
        float inputy=Input.GetAxis("Mouse Y")*Sensitivity;
        
        //Rotate the camera around x axis
        cameraVerticalRotation-=inputy;
        cameraVerticalRotation=Mathf.Clamp(cameraVerticalRotation,-90f,90f);// kameranın x eksenindeki hareketi sınırlandırılır
        transform.localEulerAngles=Vector3.right*cameraVerticalRotation;

        //Rotate the player and the camera in the y axis
        player.Rotate(Vector3.up*inputx);//hem obje hem de camera child olduğu için ikisi içinde y yönünde hareket sağlanmış olur

    }
}
