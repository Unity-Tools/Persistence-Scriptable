using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float", menuName = "SO/Variable/Float")]
public class ScriptableFloat : PersistenceScriptableVariables<float>
{
    public override float Value { get { return (float)value; } set { value = (float)value; } }
    public override float StartingValue { get { return (float)startingValue; } set { startingValue = (float)value; } }
}

