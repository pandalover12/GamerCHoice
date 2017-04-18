using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Timeer : MonoBehaviour {
    public GameObject Fallingfloor1;
    public GameObject Fallingfloor2;
    public GameObject Fallingfloor3;
    public GameObject Fallingfloor4;
    public GameObject Fallingfloor5;
    public GameObject Fallingfloor6;
    public GameObject destnation1;
    public GameObject destnation2;
    public GameObject destnation3;

    Stopwatch timer = new Stopwatch();
    // Use this for initialization
    void Start () {
        timer.Start();
        
	}
	
	// Update is called once per frame
	void Update () {
        if(timer.ElapsedMilliseconds>3000)
        {
            Fallingfloor1.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor4.GetComponent<MeshRenderer>().enabled = true;

        }
        if (timer.ElapsedMilliseconds > 5000)
        {
            Fallingfloor1.transform.Translate(0, -2, 0);
            Fallingfloor4.transform.Translate(0, -2, 0);
        }
        if (timer.ElapsedMilliseconds > 7000)
        {
            Fallingfloor2.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor5.GetComponent<MeshRenderer>().enabled = true;
        }
        if (timer.ElapsedMilliseconds > 9000)
        {
            Fallingfloor2.transform.Translate(0, -2, 0);
            Fallingfloor5.transform.Translate(0, -2, 0);
        }
        if (timer.ElapsedMilliseconds > 10000)
        {
            Fallingfloor3.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor6.GetComponent<MeshRenderer>().enabled = true;
        }
        if (timer.ElapsedMilliseconds > 12000)
        {
            Fallingfloor3.transform.Translate(0, -2, 0);
            Fallingfloor6.transform.Translate(0, -2, 0);
            Fallingfloor1.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor3.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor2.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor4.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor5.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor6.GetComponent<MeshRenderer>().enabled = false;
        }
     if(timer.ElapsedMilliseconds>14000)
     {
         Fallingfloor1.transform.position = destnation1.transform.position;
            Fallingfloor2.transform.position = destnation2.transform.position;
         Fallingfloor3.transform.position = destnation3.transform.position;
            Fallingfloor4.transform.position = destnation1.transform.position;
         Fallingfloor5.transform.position = destnation2.transform.position;
            Fallingfloor6.transform.position = destnation3.transform.position;
            timer.Reset();
            timer.Start();
     }
    }
}
