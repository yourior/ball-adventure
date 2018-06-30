using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollBall : MonoBehaviour {

    public int speed;
    public Rigidbody rb;
    public int chargespeed;
    public bool charge;
	public float chargetimer;
    public bool chargeAttack;
    private int distance;
    public AudioSource audio;

    public Slider ChargeSlider;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
		charge = false;
		chargespeed = 1;
		chargetimer = 0;
        chargeAttack = false;
        distance = 5;
    }

    // Update is called once per frame
    void Update()
    {
		ChargeSlider.value = chargetimer;

        if(chargespeed > 1)
        {
            chargeAttack = true;
        }else if(chargespeed <=1)
        {
            chargeAttack = false;
        }
        float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 Roll = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        //Roll = transform.InverseTransformDirection(Roll);

        rb.AddForce (Roll * (speed * chargespeed));


        chargetimer += 1 * Time.deltaTime;

		if (chargetimer >= 5) {
			chargetimer = 5;
		}

		if (charge == true) {
			chargespeed = speed * 2;
		} else
			chargespeed = 1;

		if (chargetimer == 5) {
			if (Input.GetKey (KeyCode.Space)) {
				charge = true;
				chargetimer = 0;
			}
		} else
			charge = false;
			
		//if (Input.GetKeyDown (KeyCode.Space)) {
		//	charge = true;
		//} else
		//	charge = false;

		//print ("Charge Timer: " + chargetimer);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tree")
        {
            audio.Play();
            Debug.Log("play");
        }

    }
}
