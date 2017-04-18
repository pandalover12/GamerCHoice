using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatings : MonoBehaviour {
    ThemagicCarpet cat = new ThemagicCarpet();
    bool mewo;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        mewo = cat.GetDragon();
        
        transform.Rotate(0.60f,0, 0);
	}
    void OnTriggerEnter(Collider other)
    {
        if (mewo == true)
        {
            other.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(mewo==false)
        other.transform.parent = null;
    }
}
