using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdoor : MonoBehaviour {

    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("open", false);
    }
	
	
    public void openDoorBoss()
    {
        anim.SetBool("open", true);
    }
    public void closeDoorBoss()
    {
        anim.SetBool("open", false);
    }
}
