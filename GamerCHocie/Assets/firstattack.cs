using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstattack : MonoBehaviour {
    int attackon;
	// Use this for initialization
	void Start () {
        attackon = 0;
        PlayerPrefs.SetInt("rawrr", attackon);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            attackon = 1;
            PlayerPrefs.SetInt("rawrr", attackon);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public int GetAttack()
    {
        attackon = PlayerPrefs.GetInt("rawrr", attackon);
        return attackon;
    }
}
