using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Vector3",menuName = "SO/Variable/Vector3")]
public class ScriptableVector3 : PersistenceScriptableVariables<Vector3>
{
    public override Vector3 Value { get { return (Vector3)value; } set { value = (Vector3)value; } }
    public override Vector3 StartingValue { get { return (Vector3)startingValue; } set { startingValue = (Vector3)value; } }
}

