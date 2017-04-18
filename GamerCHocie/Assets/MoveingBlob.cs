using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingBlob : MonoBehaviour {
    bool move = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (transform.position.z > -1.58)
            move = false;
        else if (transform.position.z < -1.72)
            move = true;
        if(move==true)
        {
            transform.Translate(0, 0, -0.04f);
        }
        if (move == false)
        {
            transform.Translate(0, 0, 0.04f);
        }
    }
 
}
