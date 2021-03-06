﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bravo : MonoBehaviour
{
    ThirdAttack temmo = new ThirdAttack();
    ThemagicCarpet dungon = new ThemagicCarpet();
    public Transform Player;
    public Transform meow;
    int attack;
    int faknum;
    // Use this for initialization
    void Start()
    {
        faknum = 0;
        attack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        attack = temmo.GetAttack();
        PlayerPrefs.SetInt("defendAmount2", attack);
        faknum = dungon.GetDungonStatus();
        if (attack == 1)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<SphereCollider>().enabled = false;
        }
        if (faknum == 0)
            transform.Translate(0, 0, 0);
        if (faknum == 1)
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
    public int GetAttack()
    {
        attack = PlayerPrefs.GetInt("defendAmount2", attack);
        return attack;
    }
}
