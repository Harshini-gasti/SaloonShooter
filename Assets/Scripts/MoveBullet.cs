using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveBullet : MonoBehaviour
{
    public float speed = 80f;
    private Rigidbody rb;
    public AudioSource glassBreak;
  



     // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }
    
    void FixedUpdate()
    {
        rb.velocity = transform.TransformDirection(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bottles")
        {
            glassBreak.Play();
            Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
            Destroy(gameObject,1.5f);

        }
        else
        {
            Destroy(gameObject,1f);
        }

    }
}
