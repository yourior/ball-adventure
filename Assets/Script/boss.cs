﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void down()
    {
        GetComponent<Animator>().SetBool("down", true);
    }
}
