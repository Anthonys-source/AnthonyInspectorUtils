using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SeparatorAttribute))]
public class SeparatorDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        position.height -= 6.0f;
        EditorGUI.LabelField(position, (attribute as SeparatorAttribute).Text);
        position.y += position.height;
        position.height = 3.0f;
        EditorGUI.DrawRect(position, Color.grey);
    }

    public override float GetHeight()
    {
        return base.GetHeight() * 1.5f;
    }
}
