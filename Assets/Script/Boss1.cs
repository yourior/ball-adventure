using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boss1 : MonoBehaviour {

    private RollBall rb;
    public GameObject[] leaves;
    private int maxleaves;
    public string level;

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
           
            Destroy(gameObject);

            for (int i = 0; i < maxleaves; i++)
                Destroy(leaves[i]);
            SceneManager.LoadScene(level);
        }
    }

}
