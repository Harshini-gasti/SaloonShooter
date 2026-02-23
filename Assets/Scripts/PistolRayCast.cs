using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolRayCast : MonoBehaviour
{
    // Get a reference for Camera Transform
    private Transform camera;

    // Get Bullet Prefab and Bullet Point references
    public GameObject bullet;
   // public Transform bulletPoint;
    public AudioSource pistolShot;

    // Cross Hair Image
    public Image crossHair;
  

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera").transform;
    
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.DrawRay(camera.position, camera.forward * 50f, Color.red);

        RaycastHit hit;

        if(Physics.Raycast(camera.position, camera.forward, out hit, 100f))
        {
            Debug.Log(hit.collider.name);
            if(hit.collider.tag == "Bottles")
            {
                crossHair.color = Color.red;
                if (Input.GetButtonDown("Fire1"))
                {
                    pistolShot.Play();
                    GameObject g = Instantiate(bullet, camera.position, camera.rotation);
                }
            }
            else
            {
                crossHair.color = Color.white;
            }
                              
            
        }

    }
    //public void ShootBullet()
    //{
    //    if(Input.GetButtonDown("Fire1"))
    //    {
    //        pistolShot.Play();
    //        GameObject g = Instantiate(bullet, camera.position, camera.rotation);
    //    }
       
    //}

  

    

}
