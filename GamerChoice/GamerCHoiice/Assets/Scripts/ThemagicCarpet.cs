using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemagicCarpet : MonoBehaviour {
    float speed = 4;
    float rotating = 0;
    public GameObject Destination;
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation   = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
        if(Player.transform.position.y<-4)
        {
            Player.transform.position = Destination.transform.position;
        }
	}
}
