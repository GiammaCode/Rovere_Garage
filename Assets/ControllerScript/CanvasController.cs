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
    public float[] carDistances = new float[ELEMENTS];
    public float[] colDistances = new float[ELEMENTS];
    public float mainCarDistance;
    public int carDetected;
    public TMP_Text labelInteractionCar;
    public TMP_Text labelInfoCar;
    public TMP_Text labelMainCar;
    public ItemContainer ic;



    // Start is called before the first frame update
    void Start()
    {
        ic = ItemContainer.Load("Cars");

    }

    // Update is called once per frame
    void Update()
    {
        labelInteractionCar.enabled = false;
        labelInfoCar.enabled = false;
        labelMainCar.enabled = false;
        //Debug.Log(labelInteractionCar);

        labelInteractionCar.enabled = checkInteractionCar(playerBody, cars, carDistances);

        setInfoLabel(labelInfoCar, playerBody, infoColumns, colDistances, ic);
        //labelInfoCar.enabled = checkInfoColumn(playerBody, infoColumns, colDistances);

        labelMainCar.enabled = checkMainCar(playerBody, mainCar, mainCarDistance);





    }

    public bool checkInteractionCar(GameObject pBody, GameObject[] cars, float[] dist)
    {
        int i = 0;
        int carDetected = 0;
        foreach (GameObject car in cars)
        {
            dist[i] = Vector3.Distance(pBody.transform.position, cars[i].transform.position);
            if (dist[i] < 1.2)
            {
                carDetected += 1;
            }
            i++;
        }
        if (carDetected > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void setInfoLabel(TMP_Text label, GameObject pBody, GameObject[] columns, float[] dist, ItemContainer ic)
    {
        int i = 0;
        int colDetected = 0;
        var index = 0;
        foreach (GameObject col in columns)
        {
            dist[i] = Vector3.Distance(pBody.transform.position, columns[i].transform.position);
            if (dist[i] < 1 && (Input.GetKey("g") || Input.GetAxis("Fire1") == 1))
            {
                colDetected += 1;
                index = i;
            }
            i++;
        }
        if (colDetected > 0)
        {
            label.enabled = true;
            label.text = "model: " + ic.cars[index].model +
                         "\r\npower: " + ic.cars[index].power +
                         "\r\nprice: " + ic.cars[index].price +
                         "\r\ntraction: " + ic.cars[index].traction;
        }
        else
        {
            label.enabled = false;
        }
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
        if (dist < 2.5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
