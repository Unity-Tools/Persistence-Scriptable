using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class SoListner
{
    public SOEvent Event;
    public List<UnityEvent> responses;
}
public class SOEventListner : MonoBehaviour
{
   
    public List<SoListner> soListners=new List<SoListner>();

    private void OnEnable()
    {
        for (int i = 0; i < soListners.Count; i++)
        {
            soListners[i].Event.RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < soListners.Count; i++)
        {
            soListners[i].Event.UnregisterListener(this);
        }
    }

    public void OnEventRaised(string EventName)
    {           
        for (int i = 0; i < soListners.Count; i++)
        {
            if (soListners[i].Event.name == EventName)
            {
                for (int j = 0; j < soListners[i].responses.Count; j++)
                {
                    soListners[i].responses[j].Invoke();
                }
            }
        }
    }


}
