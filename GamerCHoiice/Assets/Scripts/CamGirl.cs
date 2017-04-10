using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGirl : MonoBehaviour {
   public Vector3 offset;
    public GameObject Player;
  //  public Camera cam1;
  //  public Camera cam2;

	// Use this for initialization
	void Start () {
        offset = transform.position - Player.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset+Player.transform.position;
     //   if (Input.GetKeyDown("space"))
     //   {
     //       cam1.enabled = !cam1.enabled;
     //       cam2.enabled = !cam2.enabled;
     //   }

    }
}
