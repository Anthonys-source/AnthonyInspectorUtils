using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(InfoBoxAttribute))]
public class InfoBoxDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        float off = 2.0f;
        position.y += off;
        position.height -= off;
        var a = (attribute as InfoBoxAttribute);
        EditorGUI.HelpBox(position, a.Message, (MessageType)a.Type);
    }

    public override float GetHeight()
    {
        return base.GetHeight() * 2;
    }
}
