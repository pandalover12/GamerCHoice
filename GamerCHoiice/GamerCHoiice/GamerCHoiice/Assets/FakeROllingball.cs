using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeROllingball : MonoBehaviour
{
    public Transform Player;
    public Transform meow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.z < -4)
        {
            transform.LookAt(Player);
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
    }
    void  OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

