using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Int",menuName = "SO/Variable/Int")]
public class ScriptableInt : PersistenceScriptableVariables<int>
{
    public override int Value{ get { return (int)value; } set { value = (int)value; } }
    public override int StartingValue { get { return (int)startingValue; } set { startingValue = (int)value; } }
}

