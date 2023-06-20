using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCameraMovement : MonoBehaviour
{
    public Transform FPcamera;
    public Transform cameraBody;
    public Transform PlayerBody;
    public float x;
    public float y;
    public float z;

    /*
    * Update the position of player (camera an playerBody) 
    */
    void Update()
    {
        PlayerBody.transform.rotation = Quaternion.Euler(0, FPcamera.transform.rotation.eulerAngles.y, FPcamera.transform.rotation.eulerAngles.z);
        cameraBody.position = PlayerBody.position + new Vector3(x, y, z);
       
    }
}