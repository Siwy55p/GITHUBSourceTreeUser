﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyUp(KeyCode.Space))
			{
				GetComponent<MeshRenderer>().material.color = new Color(0.5f,0.5f,0.1f);
			}
	}
}
