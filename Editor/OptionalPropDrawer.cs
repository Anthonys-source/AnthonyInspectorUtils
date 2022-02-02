using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Optional<>))]
public class OptionalPropDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("m_Value"));
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty p_value = property.FindPropertyRelative("m_Value");
        SerializedProperty p_enabled = property.FindPropertyRelative("m_Enabled");

        Rect cursor = position;

        cursor.width -= 20;
        EditorGUI.BeginDisabledGroup(!p_enabled.boolValue);
        EditorGUI.BeginProperty(cursor, label, property);
        EditorGUI.PropertyField(cursor, p_value, label, true);
        EditorGUI.EndDisabledGroup();

        cursor.x += cursor.width + 2;
        cursor.width = 20;
        cursor.height = EditorGUI.GetPropertyHeight(p_enabled);
        EditorGUI.PropertyField(cursor, p_enabled, GUIContent.none);
        EditorGUI.EndProperty();
    }
}
