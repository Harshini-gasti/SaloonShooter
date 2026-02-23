using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    private float _rotationSpeed = 2.0f;
    private float _rotationX = 0f, _rotationY = 0f;
    private GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        // Camera Rotation
        _rotationY += _rotationSpeed * Input.GetAxis("Mouse X");
        _rotationX -= _rotationSpeed * Input.GetAxis("Mouse Y");
        _rotationX = Mathf.Clamp(_rotationX, -30f, 30f);
        _rotationY = Mathf.Clamp(_rotationY, -120f, 120f);
        transform.eulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }
}
