//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects
using UnityEngine;
using System.Collections;
[CreateAssetMenu(fileName = "Data",menuName ="Test/List", order =1)]
public class MyScriptableObject : ScriptableObject  {
    public string objectName = " Object name";
    public bool ColorisRandom = false;
    public Color color= Color.white;
    public Vector3[] positions; 
}
