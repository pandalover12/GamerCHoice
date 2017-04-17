using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathSpawner : MonoBehaviour {
    public GameObject Fruit;
  //  public GameObject fruit;
   public int spawnum = 3;
   // public int Enemynum = 2;
    void spawn()
    {
        for(int i = 0; i < spawnum; i++)
        {
            Vector3 fruitpos=new Vector3(this.transform.position.x+Random.Range(-1.0f,1.0f),
                this.transform.position.y+Random.Range(0.2f,0.5f),  
            this.transform.position.z + Random.Range(-1.0f, 1.0f));
            Instantiate(Fruit, fruitpos, Quaternion.identity);

        }
      // for (int i = 0; i < Enemynum; i++)
      // {
      //     Vector3 fruitpos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 1.0f),
      //         this.transform.position.y + Random.Range(0.2f, 0.5f),
      //     this.transform.position.z + Random.Range(-1.0f, 1.0f));
      //     Instantiate(fruit, fruitpos, Quaternion.identity);
      // }
    }
	// Use this for initialization
	void Start () {
        spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
