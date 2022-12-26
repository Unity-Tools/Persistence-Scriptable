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
public class ScriptableUser : PersistenceScriptableVariables
{

    public UserData Value;
    public UserData StartingValue;

    public override object MyValue { get { return (UserData)Value; } set { Value = (UserData)value; } }
    public override object MyStartingValue { get { return (UserData)StartingValue; } set { StartingValue = (UserData)value; } }

}
