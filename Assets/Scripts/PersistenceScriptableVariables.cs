using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public abstract class PersistenceScriptableVariables : ScriptableObject
{
    public bool AllowCash;
    public object Value;
    [NonSerialized]
    public object StartingValue;
    public virtual object MyValue { get { return Value; } set { Value = value; } }
    public virtual object MyStartingValue { get { return StartingValue; } set { StartingValue = value; } }

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
                JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(name), MyValue);
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
            PlayerPrefs.SetString(name, JsonUtility.ToJson(MyValue));
        }


    }

    protected void ResetValue()
    {
        MyValue = MyStartingValue;
    }

}



