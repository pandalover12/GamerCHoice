using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDo : MonoBehaviour {
    bool down;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y<6)
        {
            down = false;

        }
        if(transform.position.y>10.53)
        {
            down = true;
        }
        if (down == true)
        {
            transform.Translate(0, -0.023f, 0);
        }
        if (down == false)
        {
            transform.Translate(0, 0.023f, 0);
        }
	}
}
