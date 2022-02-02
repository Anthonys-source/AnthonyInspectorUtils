using System;
using UnityEngine;

[Serializable]
public struct Optional<T>
{
    #region Public
    public T Value => m_Value;
    public bool Enabled => m_Enabled;

    public Optional(T value)
    {
        m_Enabled = true;
        m_Value = value;
    }

    public Optional(T value, bool enabled)
    {
        m_Enabled = enabled;
        m_Value = value;
    }

    public static implicit operator Optional<T>(T v)
    {
        return new Optional<T>(v);
    }

    public static implicit operator T(Optional<T> v)
    {
        return v.Value;
    }
    #endregion

    #region Private
    [SerializeField] private T m_Value;
    [SerializeField] private bool m_Enabled;
    #endregion
}
