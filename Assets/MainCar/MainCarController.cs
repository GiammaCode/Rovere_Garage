using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarController : MonoBehaviour
{
    public GameObject car;
    public GameObject playerBody;
    public Material colorCar;
    public float distance; 
    public int indexColor;
    

    // Start is called before the first frame update
    void Start()
    {
        indexColor= 0;
        colorCar.SetColor("_Color", Color.white);
    }

    // Update is called once per frame
    void Update()
    {
       distance = Vector3.Distance(playerBody.transform.position, car.transform.position);

        car.transform.Rotate(new Vector3(0f, 0.3f, 0f));

        if(distance < 2.5)
        {
            if (Input.GetKeyDown("z"))
            {
                indexColor = setIndexColor(indexColor);
            }

            setColorCar(indexColor);
        }
    }

    private void setColorCar(int IndexColor)
    {
        switch (IndexColor)
        {
            case 1:
                colorCar.SetColor("_Color", Color.black);
                break;
            case 2:
                colorCar.SetColor("_Color", Color.red);
                break;
            case 3:
                colorCar.SetColor("_Color", Color.yellow);
                break;
            case 4:
                colorCar.SetColor("_Color", Color.grey);
                break;
        }
    }
    private int setIndexColor(int IndexColor)
    {
        IndexColor += 1;
        IndexColor = IndexColor == 5 ? 1 : IndexColor;
        return IndexColor;

    }
}
