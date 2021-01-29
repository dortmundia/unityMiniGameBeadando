using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensi = 2000f;
    public Transform playerBody;
    float xRota = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensi * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensi * Time.deltaTime;

        xRota -= mouseY;
        xRota = Mathf.Clamp(xRota, -90, 90);



        transform.localRotation = Quaternion.Euler(xRota, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}
