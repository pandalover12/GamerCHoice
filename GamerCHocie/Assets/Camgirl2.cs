using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camgirl2 : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    int math;
    ThemagicCarpet draogn = new ThemagicCarpet();
    // Use this for initialization
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        math = draogn.GetCounter();
        if (Input.GetKeyDown("c") && math == 0)
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;

        }
        if (Input.GetKeyDown("c") && math >= 1)
        {
            if (cam1.enabled == true )
            {
                cam1.enabled = false;
                cam2.enabled = true;
                cam3.enabled = false;
            }
            else if ( cam2.enabled == true )
            {
                cam1.enabled = false;
                cam2.enabled = false;
                cam3.enabled = true;
            }
            else if ( cam3.enabled == true )
            {
                cam1.enabled = true;
                cam2.enabled = false;
                cam3.enabled = false;
            }

        }

    }
}


