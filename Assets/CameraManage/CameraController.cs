using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    const int ELEMENTS = 8;
    public GameObject CameraPlayer;  
    public GameObject player;

    
    public GameObject[] cameras = new GameObject[ELEMENTS]; 
    public float[] distances = new float[ELEMENTS];

    public int CamNumber = 1;

    void start()
    {
        CameraPlayer.SetActive(true);
        foreach (GameObject camera in cameras)
        {
            camera.SetActive(false);
        }
    }


    void Update()
    {
        Debug.Log(Input.GetAxis("ButtonX"));
        CameraPlayer.SetActive(true);
        foreach (GameObject camera in cameras)
        {
            camera.SetActive(false);
        }

        int i = 0;
        foreach(float dist in distances)
        {
            distances[i] = Vector3.Distance(player.transform.position, cameras[i].transform.position);
            
            if (distances[i] < 1)
            {
                Debug.Log("distance car detected");
                if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
                {
                    CamNumber += 1;
                    CamNumber = CamNumber == 3 ? 1 : CamNumber;
                    
                }
                settingCamera(CamNumber, cameras, CameraPlayer, i);
            }
            i++;
        }
    }

    public void settingCamera(int camN, GameObject[] cameraVector, GameObject mainCam, int index )
    {
        if(camN == 1)
        {
            mainCam.SetActive(true);
            foreach (GameObject camera in cameraVector)
            {
                camera.SetActive(false);
            }
        }
        else
        {
            mainCam.SetActive(true);
            foreach (GameObject camera in cameraVector)
            {
                camera.SetActive(false);
            }
            cameraVector[index].SetActive(true);
        }

    }
   
}