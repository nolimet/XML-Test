using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class DataTest {

    [XmlAttribute("name")]
    public string Name;
    [XmlAttribute("tag")]
    public string Tag;
    [XmlArray("Images"), XmlArrayItem("Image")]
    public string[] images;
    [XmlArray("vids"), XmlArrayItem("vid")]
    public string[] vids;

    [XmlArray("about"), XmlArrayItem("line")]
    public string[] about;

    [XmlArray("devs"), XmlArrayItem("dev")]
    public string[] devs;

    [XmlArray("arts"), XmlArrayItem("art")]
    public string[] arts;

    [XmlElement("src")]
    public string source;

    [XmlElement("oth")]
    public string other;

    [XmlElement("ext")]
    public string ProjectDiscription;
    [XmlAttribute("tijd", typeof(int))]
    public int time;
}
