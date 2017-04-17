using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisable : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player.transform.position.z > 5.5)
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
        if (Player.transform.position.z < 5.5)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
