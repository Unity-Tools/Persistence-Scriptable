using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Vector3",menuName = "SO/Variable/Vector3")]
public class ScriptableVector3 : PersistenceScriptableVariables
{
    public Vector3 Value;
    public Vector3 StartingValue;
    public override object MyValue { get { return (Vector3)Value; } set { Value = (Vector3)value; } }
    public override object MyStartingValue { get { return (Vector3)StartingValue; } set { StartingValue = (Vector3)value; } }
}

