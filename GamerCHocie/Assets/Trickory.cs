using UnityEngine.UI;
using UnityEngine;

public class Trickory : MonoBehaviour {
    public GameObject Player;
    public Text Mystery;
    // Use this for initialization
    void Start()
    {
       
    }
    void FixedUpdate()
    {

        if (Player.transform.position.x >= 10)
        {
            Mystery.text = "Two Steps Back Is correct THough WHich way IS back ^.^";

        }
    }
}
