using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntekDead : MonoBehaviour {

    private RollBall rb;
    public GameObject[] leaves;
    private int maxleaves;


    // Use this for initialization
    void Start()
    {
        rb = FindObjectOfType<RollBall>();
        maxleaves = 5;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            FindObjectOfType<MainEngine>().countToBoss++;
            Debug.Log("hit");
            Destroy(gameObject);

            for (int i = 0; i < maxleaves; i++)
                Destroy(leaves[i]);
        }
    }

}
