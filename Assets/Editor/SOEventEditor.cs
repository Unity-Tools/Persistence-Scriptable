using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

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
            
            GUILayout.Label("This is List of Event Listners: \n");


            //Gui list For all Listner


            // GUILayout.Label(soEvent.listeners.ToArray().ToString());         

            for (int i = 0; i < soEvent.listeners.Count; i++)
            {
                GUILayout.Label(i+1 +") "+soEvent.listeners[i].name);
                soEvent.listeners[i] = (SOEventListner)EditorGUILayout.ObjectField("Script Location", soEvent.listeners[i], typeof(SOEventListner), false);

            }




        }
        public static void Show(SerializedProperty list)
        {
            EditorGUILayout.PropertyField(list);
            for (int i = 0; i < list.arraySize; i++)
            {
                EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
            }
        }
    }

}