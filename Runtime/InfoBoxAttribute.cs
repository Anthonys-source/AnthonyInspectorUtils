using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class InfoBoxAttribute : PropertyAttribute
{
    public string Message;
    public MessageType Type = MessageType.Info;

    public InfoBoxAttribute(string message)
    {
        Message = message;
    }

    public InfoBoxAttribute(string message, MessageType type)
    {
        Message = message;
        Type = type;
    }

    public enum MessageType
    {
        None = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    }
}
