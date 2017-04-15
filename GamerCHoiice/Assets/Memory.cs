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
        do
        {
            transform.Translate(0, 0, 0.5f);
            if(transform.position.z>2)
            {
                transform.position = Destination.transform.position;
            }

        } while (PLayer.transform.position.z < 5);
	}
}
