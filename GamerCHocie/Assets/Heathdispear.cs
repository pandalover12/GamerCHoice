using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heathdispear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
       if( other.gameObject.tag == "Player")
        {

            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<SphereCollider>().enabled = false;
        }
    }
}
