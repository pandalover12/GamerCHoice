using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class trex : MonoBehaviour
{
    charley disable = new charley();
    Bravo disable2 = new Bravo();
    minnion2 disable3 = new minnion2();
    Stopwatch timer = new Stopwatch();
    ThemagicCarpet dungon = new ThemagicCarpet();
    int attackordefend = 0;
    public GameObject Injuredbos;
   
    public Transform Player;
    public GameObject Player1;
    public GameObject Defense;
    public int titan;
    public int defense;
    int fakedefense;
    int fakedefense2;
    int fakedfense3;
    // Use this for initialization
    void Start()
    {
        titan = 0;
        defense = 0;
        attackordefend = 0;
        fakedefense = 0;
        fakedefense2 = 0;
        fakedfense3 = 0;
    }

    // Update is called once per frame
    void Update()
       
    {
        titan = dungon.GetDungonStatus();
      
        fakedefense = disable.GetAttack();
        fakedefense2 = disable2.GetAttack();
        fakedfense3 = disable3.GetAttack();
        if (fakedefense == 1)
        { defense += 1;
            fakedefense=2;

        }
        if (fakedefense2 == 1)
        {
            defense += 1;
            fakedefense2=2;
        }
        if (fakedfense3 == 1)
        {
            defense += 1;
            fakedfense3=2;
        }
        if (defense == 3||defense==6)
        {
            Defense.GetComponent<MeshRenderer>().enabled = false;
            Defense.GetComponent<BoxCollider>().enabled = false;
            Injuredbos.GetComponent<MeshRenderer>().enabled = true;
            Injuredbos.GetComponent<BoxCollider>().enabled = true;
            timer.Start();
            attackordefend = 1;
            if (timer.ElapsedMilliseconds > 3000)
            {
                Injuredbos.GetComponent<BoxCollider>().enabled = false;
                Injuredbos.GetComponent<MeshRenderer>().enabled = false;
                Defense.GetComponent<MeshRenderer>().enabled = true;
                Defense.GetComponent<BoxCollider>().enabled = true;
                attackordefend = 0;
                timer.Reset();
            }
         
        }
        if (defense == 6)
        {
            Defense.GetComponent<MeshRenderer>().enabled = false;
            Injuredbos.GetComponent<MeshRenderer>().enabled = true;
        }
            
       
      titan = dungon.GetDungonStatus();
        if(titan==0)
        transform.Translate(0, 0, 0);
        if (titan==1)
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
