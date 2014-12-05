using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("dataContainer"), System.Serializable]
public class DataContainer
{
    [XmlArray("DataChunks"), XmlArrayItem("Data")]
    public DataTest[] Test;

    public void Save(string path, string fileName)
    {
        var serializer = new XmlSerializer(typeof(DataContainer));
        Debug.Log(Path.Combine(Path.Combine(Application.dataPath, path), fileName));
        try
        {
            using (var stream = new FileStream(Path.Combine(Application.dataPath, path, fileName), FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }
        catch (IOException e)
        {
            System.IO.Directory.CreateDirectory(Path.Combine(Application.dataPath, path));
            using (var stream = new FileStream(Path.Combine(Path.Combine(Application.dataPath, path), fileName), FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }
    }

    public static DataContainer Load(string path, string fileName)
    {
        var serializer = new XmlSerializer(typeof(DataContainer));
        using (var stream = new FileStream(Path.Combine(Path.Combine(Application.dataPath, path), fileName), FileMode.Open))
        {
            return serializer.Deserialize(stream) as DataContainer;
        }
    }

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static DataContainer LoadFromText(string text)
    {
        var serializer = new XmlSerializer(typeof(DataContainer));
        return serializer.Deserialize(new StringReader(text)) as DataContainer;
    }
}
