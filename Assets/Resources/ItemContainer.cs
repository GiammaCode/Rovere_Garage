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
    
    /*
    * get collection's path in input and return the
    * value of XML deserialized
    */
    public static ItemContainer Load(string path)
    {
        //Resources is the name of directory
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));
        StringReader reader = new StringReader(_xml.text);
        ItemContainer cars = serializer.Deserialize(reader) as ItemContainer;
          
        reader.Close();
        return cars;
    }
}
