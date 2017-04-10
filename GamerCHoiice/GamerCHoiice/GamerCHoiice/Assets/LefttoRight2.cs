using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LefttoRight2 : MonoBehaviour {
    bool move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z > -70&&move==true)
            transform.Translate(-0.024f, 0, 0.02f);
        if(transform.position.z<-44&&move==false)
            transform.Translate(0.024f, 0, -0.02f);
    }
    void OnTriggerEnter(Collider other)
    {
        move = true;
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            move = false;
            other.transform.parent = null;
    }
}
