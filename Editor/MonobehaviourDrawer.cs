using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MonoBehaviour), true)]
public class MonobehaviourDrawer : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();
        serializedObject.UpdateIfRequiredOrScript();

        // Get all properties iterator
        SerializedProperty property = serializedObject.GetIterator();

        // The first property is always the script reference
        property.NextVisible(true);
        using (new EditorGUI.DisabledScope("m_Script" == property.propertyPath))
        {
            EditorGUILayout.PropertyField(property, true);
        }

        // We draw the rest of the properties until we run out of more
        while (property.NextVisible(false))
        {
            EditorGUILayout.PropertyField(property, true);
        }

        // Apply the changes made if there are any
        serializedObject.ApplyModifiedProperties();
        EditorGUI.EndChangeCheck();
    }
}
