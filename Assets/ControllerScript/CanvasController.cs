using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    const int ELEMENTS = 8;
    public GameObject[] cars = new GameObject[ELEMENTS];
    public GameObject playerBody;
    public Canvas canvas;
    public float[] distances = new float[ELEMENTS];
    public int carDetected;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        canvas.enabled = false;
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
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }
    }
}
