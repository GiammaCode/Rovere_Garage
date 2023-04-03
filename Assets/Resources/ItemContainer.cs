using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("ItemCollection")]
  
public class ItemContainer {

    [XmlArray("Items")]
    [XmlArrayItem("Item")]

    public List<Item> items = new List<Item>();
    
    public static ItemContainer Load(string path)
    {
        //Resources è la cartella
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));
        StringReader reader = new StringReader(_xml.text);
        Debug.Log("c1");
        ItemContainer items = serializer.Deserialize(reader) as ItemContainer;
        Debug.Log("c2");

     

        reader.Close();
        return items;
    }
}
