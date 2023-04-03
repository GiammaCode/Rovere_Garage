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
        foreach(Car car in ic.cars)
        {
            print(car.name);
            print(car.model);
            print(car.power);
            print(car.price);
            print(car.traction);
            print("//////////////////////");

        }
    }

}
