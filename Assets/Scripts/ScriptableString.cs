using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New String",menuName = "SO/Variable/String")]
public class ScriptableString : PersistenceScriptableVariables<string>
{
    public override string Value { get { return (string)value; } set { Value = (string)value; } }
    public override string StartingValue { get { return (string)startingValue; } set { startingValue = (string)value; } }
}

