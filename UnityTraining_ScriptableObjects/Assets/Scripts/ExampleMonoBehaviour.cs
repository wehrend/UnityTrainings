using UnityEngine;
using System.Collections;

public class ExampleMonoBehaviour : MonoBehaviour {

    public string testtext = "foo";

    [HideInInspector]
    public ExampleScriptableObject scriptableObject = ScriptableObject.CreateInstance<ExampleScriptableObject>();
}
