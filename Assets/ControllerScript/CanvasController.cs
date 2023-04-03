using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CanvasController : MonoBehaviour
{
    const int ELEMENTS = 8;
    public GameObject[] cars = new GameObject[ELEMENTS];
    public GameObject[] infoColumns = new GameObject[ELEMENTS];
    public GameObject mainCar;
    public GameObject playerBody;
    public Canvas canvas;
    public float[] distances = new float[ELEMENTS];
    public float[] colDistances = new float[ELEMENTS];
    public float mainCarDistance;
    public int carDetected;
    public TMP_Text labelInteractionCar;
    public TMP_Text labelInfoCar;
    public TMP_Text labelMainCar;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        labelInteractionCar.enabled = false;
        labelInfoCar.enabled = false;   
        //Debug.Log(labelInteractionCar);
        int i = 0;
        carDetected = 0;
        foreach(GameObject car in cars)
        {
            distances[i] = Vector3.Distance(playerBody.transform.position, cars[i].transform.position);
            if (distances[i] < 1.5)
            {
                carDetected += 1;
            }
            i++;
        }
        if(carDetected > 0)
        {
            labelInteractionCar.enabled = true;
        }
        else
        {
            labelInteractionCar.enabled = false;
        }

        labelInfoCar.enabled = checkInfoColumn(playerBody, infoColumns, colDistances);

        labelMainCar.enabled = checkMainCar(playerBody, mainCar, mainCarDistance);





    }

    public bool checkInfoColumn(GameObject pBody, GameObject[] columns, float[] dist)
    {
        int i = 0;
        int colDetected = 0;
        foreach (GameObject col in columns)
        {
            dist[i] = Vector3.Distance(pBody.transform.position, columns[i].transform.position);
            if (dist[i] < 1 && (Input.GetKey("g") || Input.GetAxis("Fire1") == 1))
            {
                colDetected += 1;
            }
            i++;
        }
        if (colDetected > 0)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    public bool checkMainCar(GameObject pBody, GameObject car, float dist)
    {
        
        dist = Vector3.Distance(pBody.transform.position, car.transform.position);
        if (dist < 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
