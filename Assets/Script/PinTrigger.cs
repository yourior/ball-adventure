using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinTrigger : MonoBehaviour {

    AudioSource audio;
    public AudioSource pin;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            audio.Play();
            Destroy(gameObject);
        }
    }
}
