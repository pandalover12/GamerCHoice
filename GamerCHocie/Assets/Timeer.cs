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
    public GameObject Fallingfloor7;
    public GameObject destnation4;
    public GameObject Fallingfloor8;
    public GameObject destnation5;
    public GameObject Fallingfloor9;
    public GameObject Fallingfloor10;
    public GameObject Fallingfloor11;
    public GameObject Fallingfloor12;
    public GameObject destnation6;
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
           // Fallingfloor1.GetComponent<MeshRenderer>().enabled = true;
           // Fallingfloor3.GetComponent<MeshRenderer>().enabled = true;
           // Fallingfloor2.GetComponent<MeshRenderer>().enabled = true;
           // Fallingfloor4.GetComponent<MeshRenderer>().enabled = false;
           // Fallingfloor5.GetComponent<MeshRenderer>().enabled = false;
           // Fallingfloor6.GetComponent<MeshRenderer>().enabled = false;
        }
        if (timer.ElapsedMilliseconds > 13000)
        {
            Fallingfloor7.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor8.GetComponent<MeshRenderer>().enabled = true;



        }
        if (timer.ElapsedMilliseconds > 15000)
        {
            Fallingfloor7.transform.Translate(0, -2, 0);
            Fallingfloor8.transform.Translate(0, -2, 0);
        }
        if (timer.ElapsedMilliseconds > 16000)
        {
            Fallingfloor9.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor10.GetComponent<MeshRenderer>().enabled = true;
        }
        if (timer.ElapsedMilliseconds > 18000)
        {
            Fallingfloor9.transform.Translate(0, -2, 0);
            Fallingfloor10.transform.Translate(0, -2, 0);
        }
        if (timer.ElapsedMilliseconds > 20000)
        {
            Fallingfloor11.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor12.GetComponent<MeshRenderer>().enabled = true;
        }
        if (timer.ElapsedMilliseconds > 22000)
        {
            Fallingfloor11.transform.Translate(0, -2, 0);
            Fallingfloor12.transform.Translate(0, -2, 0);
            Fallingfloor1.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor3.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor2.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor7.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor9.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor11.GetComponent<MeshRenderer>().enabled = true;
            Fallingfloor4.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor5.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor6.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor8.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor10.GetComponent<MeshRenderer>().enabled = false;
            Fallingfloor12.GetComponent<MeshRenderer>().enabled = false;
        }
        if (timer.ElapsedMilliseconds>24000)
     {
         Fallingfloor1.transform.position = destnation1.transform.position;
            Fallingfloor2.transform.position = destnation2.transform.position;
         Fallingfloor3.transform.position = destnation3.transform.position;
            Fallingfloor4.transform.position = destnation1.transform.position;
         Fallingfloor5.transform.position = destnation2.transform.position;
            Fallingfloor6.transform.position = destnation3.transform.position;
            Fallingfloor7.transform.position = destnation4.transform.position;
            Fallingfloor8.transform.position = destnation4.transform.position;
            Fallingfloor9.transform.position = destnation5.transform.position;
            Fallingfloor10.transform.position = destnation5.transform.position;
            Fallingfloor11.transform.position = destnation6.transform.position;
            Fallingfloor12.transform.position = destnation6.transform.position;
            timer.Reset();
            timer.Start();
     }
    }
}
