using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGirl : MonoBehaviour {
   public Vector3 offset;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        offset = transform.position - Player.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset+Player.transform.position;
	}
}
