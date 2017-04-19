using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  minion : MonoBehaviour
{
    public Transform Player;
    public Transform meow;
    public int faknum = 10;
    ThemagicCarpet dungon = new ThemagicCarpet();
    // Use this for initialization
    void Start()
    {
        faknum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        faknum = dungon.GetDungonStatus();
        if (faknum == 0)
            transform.Translate(0, 0, 0);
        if (faknum==1)
        {
            transform.LookAt(Player);
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

