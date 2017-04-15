using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trickory2 : MonoBehaviour {
    public GameObject Player;
    public Text Mystery;
    // Use this for initialization
    void Start() {
        if (Player.transform.position.x==10)
        {
            Mystery.text = "Two Steps Back Is correct THough WHich way IS back ^.^";

    }
    }
}
