using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
 
    public GameObject CameraPlayer;  
    public GameObject player;

    
    public GameObject[] cameras = new GameObject[3]; 
    public float[] distances = new float[3];

    public int CamNumber = 1;

    void start()
    {
        CameraPlayer.SetActive(true);
        cameras[0].SetActive(false);
        cameras[1].SetActive(false);
        cameras[2].SetActive(false);
    }


    void Update()
    {
        Debug.Log(Input.GetAxis("ButtonX"));
        CameraPlayer.SetActive(true);
        cameras[0].SetActive(false);
        cameras[1].SetActive(false);
        cameras[2].SetActive(false);

        for (int i = 0; i < 3; i++)
        {
            distances[i] = Vector3.Distance(player.transform.position, cameras[i].transform.position);
        }
       
        if (distances[0] < 2)
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
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    break;
                 case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(true);
                    cameras[1].SetActive(false);
                    break;
             } 
        }
        if (distances[1] < 2)
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
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(true);
                    break;
            }
        }
        if (distances[2] < 2)
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
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(false);
                    break;
                case 2:
                    CameraPlayer.SetActive(false);
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(true);
                    break;
            }
        }


    }
   
}