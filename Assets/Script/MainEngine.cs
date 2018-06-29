using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEngine : MonoBehaviour {

    public int countToBoss;
    public int bosshealth;
    public GameObject door;
    private bossdoor bd;

    private hole1 h1;
    private hole2 h2;
    private hole3 h3;


    private boss b;
    private bossplatform bp;
	// Use this for initialization
	void Start () {
        countToBoss = 0;
        bosshealth = 0;
        bd = FindObjectOfType<bossdoor>();

        h1 = FindObjectOfType<hole1>();
        h2 = FindObjectOfType<hole2>();
        h3 = FindObjectOfType<hole3>();

        b = FindObjectOfType<boss>();
        bp = FindObjectOfType<bossplatform>();
	}
	
	// Update is called once per frame
	void Update () {

        if (countToBoss >= 3)
        {
            bd.openDoorBoss();
        }

        if(bosshealth == 1)
        {
            h1.holegone();
        }
        if (bosshealth == 2)
        {
            h2.holegone();
            h3.holegone();
        }
        if (bosshealth == 3)
        {
            bp.down();
            b.down();
        }


	}


}
