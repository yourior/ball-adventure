using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerarea : MonoBehaviour {

    RollBall r;
	// Use this for initialization
	void Start () {
        r = GetComponent<RollBall>();
	}
	
	// Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            r.charge = true;
        }
    }

    
}
