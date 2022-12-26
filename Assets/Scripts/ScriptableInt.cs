using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Int",menuName = "SO/Variable/Int")]
public class ScriptableInt : PersistenceScriptableVariables
{
    public int Value;
    public int StartingValue;
    public override object MyValue { get { return (int)Value; } set { Value = (int)value; } }
    public override object MyStartingValue { get { return (int)StartingValue; } set { StartingValue = (int)value; } }
}

