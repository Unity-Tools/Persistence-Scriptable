using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SO.Events
{
    [CustomEditor(typeof(SOEvent))]
    public class SOEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            SOEvent soEvent = (SOEvent)target;
            if (GUILayout.Button("Raise Event"))
            {
                soEvent.Raise();
            }
        }
    }

}