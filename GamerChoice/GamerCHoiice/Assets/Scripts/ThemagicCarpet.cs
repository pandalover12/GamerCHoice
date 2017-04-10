using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ThemagicCarpet : MonoBehaviour {
   public float speed = 4;
    float rotating = 0;
    public int Heath = 5;
    public int Speedy = 5;
    bool dragon = false;
    public GameObject Destination;
    public GameObject Player;
    public string LoadbyLevl;
    public Text HeathText;
    public Text SpeedTimer;
    
	// Use this for initialization
	void Start () {
        HeathText.text = "Heath" + Heath;
	}

    // Update is called once per frame
    void Update() {
        HeathText.text = "Heath" + Heath;
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
        if (Input.GetKeyDown("space"))
        {
           speed =speed *2;
            transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        }


        speed = 4;


        
        if (Player.transform.position.y < -4 && Heath != 0)
        {

            Heath--;
        }
        if (Player.transform.position.y < -4 && Heath != 0)
        {
            Player.transform.position = Destination.transform.position;

        }
        if (Heath <= 0)
        {
            SceneManager.LoadScene(LoadbyLevl);
        }
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atk1"|| other.gameObject.tag == "Atk2")
        {
            Heath--;
        }
        if(other.gameObject.tag=="Enemy")
        {
            Heath--;
        }
        if (other.gameObject.tag == "SpeedBoost" )
        {
            Speedy++;
          
        } 
      
    }
    public bool GetDragon()
    {
        return dragon;
    }
    
}
