using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "SO/Events/Event")]
public class SOEvent : ScriptableObject
{

    List<SOEventListner> listeners = new List<SOEventListner>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
    public void RegisterListener(SOEventListner listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(SOEventListner listener)
    {
        listeners.Remove(listener);
    }

    }
