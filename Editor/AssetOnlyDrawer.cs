using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(AssetOnlyAttribute))]
public class AssetOnlyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.objectReferenceValue != null && !AssetDatabase.Contains(property.objectReferenceValue))
            property.objectReferenceValue = null;
        EditorGUI.PropertyField(position, property, label);
    }
}
