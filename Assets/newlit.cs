using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class newlit : MonoBehaviour {
    public Color test;
    public Light l;
    public Image i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        l.color = test;
        i.color = test;
	}
}
