using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=20f;
    public Transform tr;
    public bool ontheground=true;//check player is on ground or not
    // Start is called before the first frame update
    void Start()
    {
        //Stop the Rigidbody from rotating
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    
    //void Update()
    //{
    //    float rot_y=Input.GetAxis("Mouse X");
    //    transform.rotation=transform.rotation*Quaternion.Euler(0.0f,rot_y,0.0f);
    //    float rot_x=Input.GetAxis("Mouse Y");

    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(Horizontal,0.0f,Vertical)*Time.deltaTime*speed;
        tr.Translate(move,Space.Self);
        //rb.AddForce(move*speed);

        if (Input.GetButton("Jump") && ontheground==true)
        {
            rb.AddForce(new Vector3(0,5,0),ForceMode.Impulse);
            ontheground=false;
        }

        if(rb.position.y<-10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        ontheground=true;
    }
}
