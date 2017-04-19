using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trex : MonoBehaviour
{
    ThemagicCarpet dungon = new ThemagicCarpet();
    int attackordefend = 0;
   
    public Transform Player;
    public GameObject Player1;
    public int faknum = 10;
    // Use this for initialization
    void Start()
    {
        faknum = 0;
       
    }

    // Update is called once per frame
    void Update()
       
    {

       faknum= dungon.GetDungonStatus();
        if(faknum==0)
        transform.Translate(0, 0, 0);
        if (faknum==1)
        switch (attackordefend)
        {
            case 0:
                transform.LookAt(Player);
                transform.Translate(Vector3.forward * 3.5f * Time.deltaTime);
                break;
            case 1:
                transform.LookAt(Player);
                transform.Translate(Vector3.back * 3.5f * Time.deltaTime);
                break;
        }
    }
}
