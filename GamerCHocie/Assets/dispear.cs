using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispear : MonoBehaviour
{
    public bool playerindungon;
    bool x = false;

    // Use this for initialization
    void Start()
    {
        playerindungon = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            playerindungon = x;
            
        }
    }
    public bool player()
    {
        
        return playerindungon;
    }
}
