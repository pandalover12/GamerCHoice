using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LefttoRight : MonoBehaviour {
    bool left;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (transform.position.x >= 5)
            left = false;
        if(transform.position.x<=-1.55f)
        {
            left = true;
        }
        if (left == false)
        {
            transform.Translate(-0.03f, 0, 0);
        }
        if(left==true)
            transform.Translate(0.03f, 0, 0);
    }
}
