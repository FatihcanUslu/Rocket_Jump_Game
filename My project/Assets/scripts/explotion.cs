using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotion : MonoBehaviour
{
    public float force=10f;
    public float expradius=10f;
    public float life=5;
    public AudioClip exp;

    void Awake()
    {
        Destroy(gameObject,life);//if it wont touch anything its gona destroy in 5 sec
        Debug.Log("Destroyed:D");
    }
   private void OnCollisionEnter(Collision collision)
   {
    Vector3 expPos=transform.position;
    Collider[] colliders=Physics.OverlapSphere(expPos,expradius);
    foreach(Collider collider in colliders)
    {
        Rigidbody rb = collider.GetComponent<Rigidbody>();//bütün rigidbody'si olan nesneleri tutar. Bütün nesneler belirlediğimiz alanın içindemi bunun kontrolü yapılır.
        if (rb !=null)
        {
            Debug.Log("Explosion occur");
            AudioSource.PlayClipAtPoint(exp, this.gameObject.transform.position);//audiosource.play() destroy bitmeden çalışmazsa hiç çalışmaz.
            
            //gameObject.GetComponent<AudioSource>().Play();
            rb.AddExplosionForce(force,expPos,expradius,0.05f,ForceMode.Impulse);
        }

    }
    Destroy(gameObject);
   }
}
