using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ThemagicCarpet : MonoBehaviour {
    public float speed;
    float counter;
    float rotating = 0;
    public int Heath = 5;
    public float Speedy = 1000;
    bool dragon;
    bool dragon2;
    bool dragon3 = true;
    public GameObject Destination;
    public GameObject Player;
    public string LoadbyLevl;
    public Text HeathText;
    public Text SpeedTimer;
    public float fakespeedy;
    
	// Use this for initialization
	void Start () {
        HeathText.text = "Heath" + Heath;
        speed = 4;
	}

    // Update is called once per frame
    void Update() {
        
        HeathText.text = "Heath" + Heath;
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
        if (Input.GetKeyDown("space"))
        {
            dragon = true;
            dragon3 = true;
        }
        if (dragon == true&&Speedy+400>=fakespeedy)
        {
            while(dragon3==true)
            {
                fakespeedy = Speedy;
                dragon3 = false;
            }

            dragon2 = true;
            
            speed = 8;
        }
        if(dragon2==true)
        {
           
            Speedy--;
            Speedy--;
            Speedy--;
            Speedy--;
            
        }

        if (Speedy +400 <= fakespeedy || Input.GetKeyDown(KeyCode.A))
        {
            speed = 4;
            dragon2 = false;
            dragon=false;
        }
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
            Speedy+=150;
          
        } 
      
    }
    public bool GetDragon()
    {
        return dragon;
    }
    
}
