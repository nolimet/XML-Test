using UnityEngine;
using System.Collections;
using UnityEditor;
[CustomEditor(typeof(XMLHandler))]
public class XmlHandlerEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        XMLHandler obj = (XMLHandler)target;
        if (GUILayout.Button("Save"))
            obj.Save();
        if (GUILayout.Button("Load"))
            obj.Load();
    }
}
