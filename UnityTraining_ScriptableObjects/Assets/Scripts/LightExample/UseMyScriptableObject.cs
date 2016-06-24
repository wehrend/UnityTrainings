//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseMyScriptableObject : MonoBehaviour {
    public MyScriptableObject scriptobj;
    private List<Light> lights;
    

	// Use this for initialization
	void Start () {
        lights = new List<Light>();
        foreach (Vector3 position in scriptobj.positions){
            GameObject light = new GameObject("Light");
            light.AddComponent<Light>();
            light.transform.position = position;
            light.GetComponent<Light>().enabled = false;
            if (scriptobj.ColorisRandom){
                light.GetComponent<Light>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

            }
            else {
                light.GetComponent<Light>().color = scriptobj.color;               
            }
            lights.Add(light.GetComponent<Light>());
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            foreach (Light light in lights)
            {
                light.enabled = !light.enabled;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            UpdateLights();
        }

    }

    void UpdateLights()
    {
        foreach (var myLight in lights)
        {
            myLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }

}
