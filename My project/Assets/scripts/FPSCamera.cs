using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public Transform player;
    public float Mouse_Sensitivity=2f;
    float Camera_Vertical_Rotation=0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float input_for_x=Input.GetAxis("Mouse X")*Mouse_Sensitivity;
        float input_for_y=Input.GetAxis("Mouse Y")*Mouse_Sensitivity;
        float arbitraj=90f;
        //Rotate the camera around x axis
        Camera_Vertical_Rotation-=input_for_y;
        Camera_Vertical_Rotation=Mathf.Clamp(Camera_Vertical_Rotation,-arbitraj,arbitraj);// kameranın x eksenindeki hareketi sınırlandırılır
        transform.localEulerAngles=Vector3.right*Camera_Vertical_Rotation;

        //Rotate the player and the camera in the y axis
        player.Rotate(Vector3.up*input_for_x);//hem obje hem de camera child olduğu için ikisi içinde y yönünde hareket sağlanmış olur

    }
}
