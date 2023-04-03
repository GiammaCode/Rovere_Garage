using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Car {
    [XmlAttribute("name")]
    public string name;
    
    [XmlElement("Model")]
    public string model;

    [XmlElement("Power")]
    public string power;

    [XmlElement("Price")]
    public string price;

    [XmlElement("Traction")]
    public string traction;
}
