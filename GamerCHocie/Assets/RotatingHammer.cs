using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class RotatingHammer : MonoBehaviour {
    bool isrotatingtrue = true;
    Stopwatch timer = new Stopwatch();
    bool left = true;
    // Use this for initialization
    void Start () {
        timer.Start();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isrotatingtrue == true)
        {
            transform.Rotate(1.525f, 0, 0);
        }
         if (isrotatingtrue == false)
        {
            transform.Rotate(-1.525f, 0, 0);
        }
     
       
          if(timer.ElapsedMilliseconds>2700&&left==true)
        {
            isrotatingtrue = false;
            left = false;
            timer.Reset();
            timer.Start();
        }
         if(timer.ElapsedMilliseconds > 2700 && left == false)
        {
            isrotatingtrue = true;
            left = true;
            timer.Reset();
            timer.Start();
        }
	}
}
