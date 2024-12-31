
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public abstract class PersistenceScriptableVariables<T> : ScriptableObject
{
    public bool AllowCash;
  //  [NonSerialized]
    public T value;
   // [NonSerialized]
    public T startingValue;
    public virtual T Value { get { return value; } set { this.value = value; } }
    public virtual T StartingValue { get { return startingValue; } set { startingValue = value; } }

    protected void OnEnable()
    {
        if (!PlayerPrefs.HasKey(name))
        {
            PlayerPrefs.SetString(name, null);
            ResetValue();
        }
        else
        {
            if (AllowCash)
            {
                JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(name), Value);
            }
        }
    }

    protected void OnDisable()
    {
        if (!PlayerPrefs.HasKey(name) || !AllowCash)
        {
            ResetValue();
        }
        else 
        {
            PlayerPrefs.SetString(name, JsonUtility.ToJson(Value));
        }


    }

    protected void ResetValue()
    {
        Value = StartingValue;
    }

}



