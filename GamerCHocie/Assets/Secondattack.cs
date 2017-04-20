using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secondattack : MonoBehaviour
{
    int attackon;
    // Use this for initialization
    void Start()
    {
        attackon = 0;
        PlayerPrefs.SetInt("mooo", attackon);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            attackon = 1;
            PlayerPrefs.SetInt("mooo", attackon);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public int GetAttack()
    {
        attackon = PlayerPrefs.GetInt("mooo", attackon);
        return attackon;
    }
}