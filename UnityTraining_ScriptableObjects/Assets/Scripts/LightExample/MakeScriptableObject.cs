using UnityEngine;
using UnityEditor;
using System.Collections;

public class MakeScriptableObject {
    [MenuItem("Assets/Create/Make Scriptable Object")]

    public static void CreateMyAsset(){
        MyScriptableObject asset = ScriptableObject.CreateInstance<MyScriptableObject>();

        AssetDatabase.CreateAsset(asset, "Assets/NewScripableObject.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;

    }
}
