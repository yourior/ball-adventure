﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole3 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<Animator>().SetBool("open", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void holegone()
    {
        GetComponent<Animator>().SetBool("open", true);
    }
}
