using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upanddown : MonoBehaviour {
    bool up = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 7)
             up = false;
        if (transform.position.y < 0)
            up = true;
        if(up==false)
        transform.Translate(0, -0.01f, 0);
        if(up == true)
            transform.Translate(0, 0.03f, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            other.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Player")
        other.transform.parent = null;
    }
}
