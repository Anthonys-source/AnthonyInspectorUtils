using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Reflection;

[CustomPropertyDrawer(typeof(CustomValueAttribute))]
public class CustomValueDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // We update the original SO if its required
        // (this could not be necesary but we haven't found a way to be sure)
        property.serializedObject.UpdateIfRequiredOrScript();

        // Cast attribute
        CustomValueAttribute attr = attribute as CustomValueAttribute;

        // Get the user defined method from supplied method name in the attribute
        MethodInfo method = fieldInfo.DeclaringType.GetMethod(attr.FunctionName);
        if (method == null)
            throw new ArgumentException($"[CUSTOM INSPECTOR ERROR]: The method with name ({attr.FunctionName}) couldn't be found in the class ({fieldInfo.DeclaringType})");

        // Prepare the arguments to call the method
        object[] d = new object[] { label, property.intValue };

        // Call the method and apply the new vale to the serialized property
        property.intValue = (int)method.Invoke(null, d);
        property.serializedObject.ApplyModifiedProperties();
    }
}
