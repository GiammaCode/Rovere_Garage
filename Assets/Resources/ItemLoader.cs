using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour
{
    public const string path = "Cars";
   

    // Start is called before the first frame update
    void Start()
    {

        ItemContainer ic = ItemContainer.Load(path);
        for (int i=1; i<8; i++)
        {
            var car = ic.cars[i];
            print(car.model);
        }
    }

}
