using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEngine : MonoBehaviour {

    public int countToBoss;
    private int bosshealth;
    public GameObject door;
    private bossdoor bd;
   
	// Use this for initialization
	void Start () {
        countToBoss = 0;
        bosshealth = 0;
        bd = FindObjectOfType<bossdoor>();
	}
	
	// Update is called once per frame
	void Update () {

        if (countToBoss >= 3)
        {
            bd.openDoorBoss();
        }
	}


}
