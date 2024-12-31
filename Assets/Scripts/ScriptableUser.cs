using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct UserData
{
    public string Name;
    public string Password;
    public string Email;
}

[CreateAssetMenu(fileName ="New User", menuName = "SO/Variable/User")]
public class ScriptableUser : PersistenceScriptableVariables<UserData>
{
    public override UserData Value { get { return (UserData)value; } set { value = (UserData)value; } }
    public override UserData StartingValue { get { return (UserData)startingValue; } set { startingValue = (UserData)value; } }

}
