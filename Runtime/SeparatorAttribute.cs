using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class SeparatorAttribute : PropertyAttribute
{
    public string Text;

    public SeparatorAttribute(string text)
    {
        Text = text;
    }
}
