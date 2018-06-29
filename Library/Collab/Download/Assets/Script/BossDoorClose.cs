using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDoorClose : MonoBehaviour {

    private bossdoor bd;
    void Start()
    {
        bd = FindObjectOfType<bossdoor>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            bd.closeDoorBoss();
        }
    }
}
