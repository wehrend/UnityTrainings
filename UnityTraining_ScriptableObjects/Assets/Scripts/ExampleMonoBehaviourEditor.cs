//http://abxygames.com/2015/08/31/unity-trick-1-make-an-inspector-for-any-scriptableobject/
using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ExampleMonoBehaviour))]
public class ExampleMonoBehaviourEditor :  Editor {

    private Editor editorCached;

    private bool editorCachedNeedsRefresh = true;

    public void OnEnable()
    {
        editorCached = null;
        editorCachedNeedsRefresh = true;
    }

    public override void OnInspectorGUI()
    {
        //grabbing the object this inspector is editing
        ExampleMonoBehaviour editedMonoBehaviour = (ExampleMonoBehaviour) target;

        if (editorCachedNeedsRefresh)
        {
            editorCached = Editor.CreateEditor(editedMonoBehaviour.scriptableObject);
            editorCachedNeedsRefresh = false;
        }


        base.OnInspectorGUI();

        editorCached.DrawDefaultInspector();
    }

}
