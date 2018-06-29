using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDoorClose : MonoBehaviour {

    private bossdoor bd;
    private MainEngine me;
    void Start()
    {
        bd = FindObjectOfType<bossdoor>();
        me = FindObjectOfType<MainEngine>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            bd.closeDoorBoss();
            me.countToBoss = 0;
        }
    }
}
