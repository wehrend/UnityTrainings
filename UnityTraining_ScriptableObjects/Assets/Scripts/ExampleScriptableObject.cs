//http://abxygames.com/2015/08/31/unity-trick-1-make-an-inspector-for-any-scriptableobject/
using UnityEngine;
using System.Collections;

[System.Serializable]
public class ExampleScriptableObject : ScriptableObject {

    //Variables we want displayed in thge inspector
    public float Value1 = 42f;
    public int Value2 = 23;

}
