using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour {
    public GameObject fruit;
    public int Enemynum = 3;
    public GameObject Fruits;
    public int fruitnum = 5;
	// Use this for initialization
    void spawn()
    {
        for (int i = 0; i < fruitnum; i++)
        {
            Vector3 fruitpos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 1.0f),
                this.transform.position.y + Random.Range(0.2f, 0.5f),
            this.transform.position.z + Random.Range(-1.0f, 1.0f));
            Instantiate(Fruits, fruitpos, Quaternion.identity);
        }
        for (int i = 0; i < Enemynum; i++)
         {
             Vector3 fruitpos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 1.0f),
                 this.transform.position.y + Random.Range(0.2f, 0.5f),
             this.transform.position.z + Random.Range(-1.0f, 1.0f));
             Instantiate(fruit, fruitpos, Quaternion.identity);
         }
    }
    void Start () {
        spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
