using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour {
    public GameObject PLayer;
    public GameObject Destination;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        {
            transform.Translate(0, 0, 0.09f);
            if(transform.position.z>5)
            {
                transform.position = Destination.transform.position;
            }

        }
	}
}
