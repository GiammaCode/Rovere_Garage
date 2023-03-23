using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customizations : MonoBehaviour
{
    public Material bodyColor;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setColor(Color c)
    {
        bodyColor.color = c;
    }
}
