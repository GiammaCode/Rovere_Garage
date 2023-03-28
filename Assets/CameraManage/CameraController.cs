using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
 
    public GameObject CameraPlayer;  
    public GameObject player;

    
    public GameObject[] cameras = new GameObject[5]; 
    public float[] distances = new float[5];

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
            i++;
        }
       
        if (distances[0] < 1)
        {
            Debug.Log("distance car detected");
            if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
            {
                CamNumber += 1;
                if(CamNumber == 3){
                    CamNumber = 1;
                }
            }
             switch (CamNumber)
             {
                 case 1:
                    CameraPlayer.SetActive(true);
                    foreach (GameObject camera in cameras)
                    {
                        camera.SetActive(false);
                    }
                    break;
                 case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(true);
                    cameras[1].SetActive(false);
                    break;
             } 
        }
        if (distances[1] < 1)
        {
            Debug.Log("distance car detected");
            if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
            {
                CamNumber += 1;
                if (CamNumber == 3)
                {
                    CamNumber = 1;
                }
            }
            switch (CamNumber)
            {
                case 1:
                    CameraPlayer.SetActive(true);
                    foreach (GameObject camera in cameras)
                    {
                        camera.SetActive(false);
                    }
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(true);
                    break;
            }
        }
        if (distances[2] < 1)
        {
            Debug.Log("distance car detected");
            if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
            {
                CamNumber += 1;
                if (CamNumber == 3)
                {
                    CamNumber = 1;
                }
            }
            switch (CamNumber)
            {
                case 1:
                    CameraPlayer.SetActive(true);
                    foreach (GameObject camera in cameras)
                    {
                        camera.SetActive(false);
                    }
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(true);
                    break;
            }
        }
        if (distances[3] < 1)
        {
            Debug.Log("distance car detected");
            if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
            {
                CamNumber += 1;
                if (CamNumber == 3)
                {
                    CamNumber = 1;
                }
            }
            switch (CamNumber)
            {
                case 1:
                    CameraPlayer.SetActive(true);
                    foreach (GameObject camera in cameras)
                    {
                        camera.SetActive(false);
                    }
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(false);
                    cameras[3].SetActive(true);
                    cameras[4].SetActive(false);
                    break;
            }
        }
        if (distances[4] < 1)
        {
            Debug.Log("distance car detected");
            if (Input.GetKeyDown("f") || Input.GetAxis("ButtonX") == 1)
            {
                CamNumber += 1;
                if (CamNumber == 3)
                {
                    CamNumber = 1;
                }
            }
            switch (CamNumber)
            {
                case 1:
                    CameraPlayer.SetActive(true);
                    foreach (GameObject camera in cameras)
                    {
                        camera.SetActive(false);
                    }
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(false);
                    cameras[3].SetActive(false);
                    cameras[4].SetActive(true);
                    break;
            }
        }


    }
   
}