using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class badtext : MonoBehaviour {
    public GameObject Player;
    public Text cat;
    public string mystring;
    public float fadetime = 0;
    
	// Use this for initialization
	void Start () {
        cat = GameObject.Find("Past").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        cat.text = mystring;
        if (Player.transform.position.z < 5.5)
        {
            cat.color = Color.Lerp(cat.color, Color.black, fadetime * Time.deltaTime);
        }
        if (Player.transform.position.z > 5.55)
        {
            cat.color = Color.Lerp(cat.color, Color.clear, fadetime * Time.deltaTime);
        }
    
    }
}
