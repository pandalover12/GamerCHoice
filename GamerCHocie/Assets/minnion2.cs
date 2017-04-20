using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minnion2 : MonoBehaviour
{
    Secondattack tiger = new Secondattack();
    ThemagicCarpet dungon = new ThemagicCarpet();
    public Transform Player;
    public Transform meow;
    int faknum;
    int attack;
    // Use this for initialization
    void Start()
    {
        attack = 0;
        faknum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        attack = tiger.GetAttack();
        PlayerPrefs.SetInt("defenseamount", attack);
        if (attack == 1)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<SphereCollider>().enabled = false;
        }
        faknum = dungon.GetDungonStatus();
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
        attack = PlayerPrefs.GetInt("defenseamount", attack);
        return attack;
    }
}
