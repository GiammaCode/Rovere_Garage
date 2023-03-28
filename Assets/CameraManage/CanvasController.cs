using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public GameObject car;
    public GameObject playerBody;
    public Canvas infoCanvas;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance =  Vector3.Distance(playerBody.transform.position, car.transform.position);
        if (distance<4)
        {
            infoCanvas.enabled = true;
        }
        else
        {
            infoCanvas.enabled = false;
        }

    }
}
