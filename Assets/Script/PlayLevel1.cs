using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLevel1 : MonoBehaviour {
    public string level;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void Scene1 () {
		SceneManager.LoadScene (level);
	}

}
