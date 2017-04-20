using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charley : MonoBehaviour
{
    firstattack legend = new firstattack();
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
        attack = legend.GetAttack();
        PlayerPrefs.SetInt("Defnender3", attack);
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
        attack = PlayerPrefs.GetInt("Defnender3", attack);
        return attack;
    }
}
