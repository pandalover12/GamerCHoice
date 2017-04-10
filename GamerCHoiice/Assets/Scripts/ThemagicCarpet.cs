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
    public float Speedy = 0;
    bool dragon;
    bool dragon2;
    bool dragon3 = true;
    public GameObject Destination;
    public GameObject Player;
    public string LoadbyLevl;
    public Text HeathText;
    public Text BoostLeft;
    public float fakespeedy;
    
	// Use this for initialization
	void Start () {
     Speedy =PlayerPrefs.GetFloat("Boost", Speedy);
     Heath  = PlayerPrefs.GetInt("Heath", Heath);
        BoostLeft.text = "Boost" + Speedy;
        HeathText.text = "Heath" + Heath;
        speed = 4;
	}

    // Update is called once per frame
    void Update() {

        Speedy = PlayerPrefs.GetFloat("Boost", Speedy);
        Heath  =  PlayerPrefs.GetInt("Heath", Heath);
        
        HeathText.text = "Heath" + Heath;
        BoostLeft.text = "Boost" + Speedy;
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
        if (Input.GetKeyDown("space")&&Speedy>0)
        {
           
            PlayerPrefs.SetFloat("Boost", Speedy);
            BoostLeft.text = "Boost" + Speedy;

            dragon = true;
            dragon3 = true;
        }
        if (dragon == true&&Speedy+2000>=fakespeedy)
        {
            while(dragon3==true)
            {
                

                fakespeedy = Speedy;
                dragon3 = false;
            }
            PlayerPrefs.SetFloat("Boost", Speedy);

            dragon2 = true;
            
            speed = 8;
        }
        if(dragon2==true)
        {
            PlayerPrefs.SetFloat("Boost", Speedy);

            Speedy--;
            PlayerPrefs.SetFloat("Boost", Speedy);

            Speedy--;
            PlayerPrefs.SetFloat("Boost", Speedy);

            Speedy--;
            PlayerPrefs.SetFloat("Boost", Speedy);

            Speedy--;
            PlayerPrefs.SetFloat("Boost", Speedy);


        }

        if (Speedy +2000 <= fakespeedy || Input.GetKeyDown(KeyCode.A))
        {
          

            speed = 4;
            dragon2 = false;
            dragon=false;
        }
        if (Player.transform.position.y < -4 && Heath != 0)
        {
           
            Heath--;
            PlayerPrefs.SetInt("Heath", Heath);
        }
        if (Player.transform.position.y < -4 && Heath != 0)
        {
            Player.transform.position = Destination.transform.position;

        }
        if (Input.GetKey("escape"))
        {
            Speedy = 0;
            Heath = 5;
            PlayerPrefs.SetInt("Heath", Heath);
            PlayerPrefs.SetFloat("Boost", Speedy);
            Application.Quit();
        }
        if (Heath <= 0)
        {
            Speedy = 0;
            Heath = 5;
            PlayerPrefs.SetInt("Heath", Heath);
            PlayerPrefs.SetFloat("Boost", Speedy);
            SceneManager.LoadScene(LoadbyLevl);
        }
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atk1"|| other.gameObject.tag == "Atk2")
        {
           
            Heath--;
            PlayerPrefs.SetInt("Heath", Heath);
        }
        if(other.gameObject.tag=="Enemy")
        {
            
            Heath--;
            PlayerPrefs.SetInt("Heath", Heath);
        }
        if (other.gameObject.tag == "SpeedBoost" )
        {
            Speedy+=6000;
            PlayerPrefs.SetFloat("Boost", Speedy);
          
        } 
      
    }
    public bool GetDragon()
    {
        return dragon;
    }
    
}
