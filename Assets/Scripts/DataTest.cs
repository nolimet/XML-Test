using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class DataTest {

    public enum gameTypes{
        unity3d = 0,
        flash = 1,
        other = 2
    }
    [XmlAttribute("name")]
    public string Name;
    [XmlAttribute("id")]
    public string id;
    [XmlAttribute("type", typeof(int))]
    public int type;
    [XmlAttribute("tag")]
    public string Tag;
    [XmlArray("images"), XmlArrayItem("image")]
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
    public exstraData extra;

    [System.Serializable]
    public class exstraData
    {
        [XmlAttribute("tijd")]
        public string tijdAangewerkt;
        [XmlAttribute("datum")]
        public string datumProjectStart;
        [XmlElement("opdr")]
        public string opdracht;
        
    }
}
