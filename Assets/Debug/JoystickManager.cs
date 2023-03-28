using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") == 1)
        {
            Debug.Log("Button0: fire1");
        }
        if (Input.GetAxis("Fire2") == 1)
        {
            Debug.Log("Button1: fire2");
        }
        if (Input.GetAxis("Submit") == 1)
        {
            Debug.Log("Button2: submit");
        }
        if (Input.GetAxis("Jump") == 1)
        {
            Debug.Log("Button3: jump");
        }
    }
}
