using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    public int MoveSpeed;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - Player.transform.position;
        MoveSpeed = 1;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Player.transform.position + offset;
	}
    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            
            transform.Rotate(Vector3.down *2);
           
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up *2 );
        }
    }



}
