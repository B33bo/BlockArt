using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AddWindow : EditorWindow
{
    #region Variables
    string Name;
    Sprite Sp;
    #endregion
    [MenuItem("Window/Developer/AddItem")]
    public static void ShowWindow()
    {
        GetWindow<AddWindow>("Add Something");
    }

    private void OnGUI()
    {
        GUILayout.Label("Add Something");

        Name = EditorGUILayout.TextField("Enter A Name", Name);
    }
}