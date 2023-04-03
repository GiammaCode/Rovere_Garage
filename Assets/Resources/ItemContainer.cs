using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("CarsCollection")]
  
public class ItemContainer {

    [XmlArray("Cars")]
    [XmlArrayItem("Car")]

    public List<Car> cars = new List<Car>();
    
    public static ItemContainer Load(string path)
    {
        //Resources è la cartella
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));
        StringReader reader = new StringReader(_xml.text);
        Debug.Log("c1");
        ItemContainer cars = serializer.Deserialize(reader) as ItemContainer;
        Debug.Log("c2");

     

        reader.Close();
        return cars;
    }
}
