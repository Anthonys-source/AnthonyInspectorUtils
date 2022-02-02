using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class CustomValueAttribute : PropertyAttribute
{
    public string FunctionName { get; private set; }

    public CustomValueAttribute(string functionName)
    {
        FunctionName = functionName;
    }
}
