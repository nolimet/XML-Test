using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
[CustomEditor(typeof(XMLHandler))]
public class XmlHandlerEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        XMLHandler obj = (XMLHandler)target;
        if (GUILayout.Button("Save"))
        {
            obj.Save();
        }

        if (GUILayout.Button("Load"))
        {
            obj.Load();
        }

        if (GUILayout.Button("Sort by Tag"))
        {
            SortListByTag(obj);
        }

        if (GUILayout.Button("Sort by Name"))
        {
            SortListByName(obj);
        }
    }

    public void SortListByTag(XMLHandler obj)
    {
        List<XmlDataStructure> tempData = obj.data.Test.ToList();

        obj.data.Test = tempData.OrderBy(x => x.Tag).ToArray();
    }

    public void SortListByName(XMLHandler obj)
    {
        List<XmlDataStructure> tempData = obj.data.Test.ToList();

        obj.data.Test = tempData.OrderBy(x => x.Name).ToArray();
    }
}
