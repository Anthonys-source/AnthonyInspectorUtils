using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    [Separator("First Title")]
    public Optional<Vector3> Optional = Vector3.forward;

    [ReadOnly]
    public float ReadOnly = 3;

    [Separator("Second Title")]

    [AssetOnly]
    public GameObject AssetOnly;

    [InfoBox("Custom Warning", InfoBoxAttribute.MessageType.Warning)]
    [InfoBox("Custom Error", InfoBoxAttribute.MessageType.Error)]
    [Separator("Title 2")]
    [InfoBox("Custom Info", InfoBoxAttribute.MessageType.Info)]
    [InfoBox("Custom Message", InfoBoxAttribute.MessageType.None)]
    [SceneObjectOnly]
    public GameObject SceneObjectOnly;

    [CustomValue("Function2")]
    public int a;

    public static int Function2(GUIContent label, int value)
    {
        return UnityEditor.EditorGUILayout.IntSlider(label, value, 0, 4);
    }
}
