using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New String",menuName = "SO/Variable/String")]
public class ScriptableString : PersistenceScriptableVariables
{
    public string Value;
    public string StartingValue;
    public override object MyValue { get { return (string)Value; } set { Value = (string)value; } }
    public override object MyStartingValue { get { return (string)StartingValue; } set { StartingValue = (string)value; } }
}

