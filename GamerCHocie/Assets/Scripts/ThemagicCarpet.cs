using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ThemagicCarpet : MonoBehaviour {
    public float speed;
    int counter;
    float rotating = 0;
    public int Heath = 5;
    public int Keys = 1;
    public float Speedy = 0;
    bool dragon;
    bool dragon2;
    bool dragon3 = true;
    public int fakenumber = 0;
    public GameObject Destination;
    public GameObject Player;
    public GameObject Door;
    public GameObject Subdoor;
    public GameObject NewArea1;
    public string LoadbyLevl;
    public Text HeathText;
    public Text BoostLeft;
    public float fakespeedy;
    public bool opendoor;
    public bool Checkpoint = false;
   
	// Use this for initialization
	void Start () {
        if (Checkpoint == false)
        {
            fakenumber = 0;
            PlayerPrefs.SetInt("dungon", fakenumber);
            // Checkpoint = false;
            opendoor = false;
            counter = PlayerPrefs.GetInt("level", counter);
            Speedy = PlayerPrefs.GetFloat("Boost", Speedy);
            Heath = PlayerPrefs.GetInt("Heath", Heath);
            Keys = PlayerPrefs.GetInt("keys", Keys);
        }
        if (Checkpoint == true)
        {
            fakenumber = 0;
            PlayerPrefs.SetInt("dungon", fakenumber);
            opendoor = false;
            counter = PlayerPrefs.GetInt("Checkpoint2", counter);
            Heath = PlayerPrefs.GetInt("Checkpoint", Heath);
            Speedy = PlayerPrefs.GetFloat("Checkpoint1", Speedy);
            Keys = PlayerPrefs.GetInt("Checkpoint3", Keys);
            PlayerPrefs.SetInt("level", counter);
            PlayerPrefs.SetFloat("Boost", Speedy);
            PlayerPrefs.SetFloat("Heath", Heath);
            PlayerPrefs.SetFloat("keys", Keys);
           
        }
     
        
            BoostLeft.text = "Boost" + Speedy;
            HeathText.text = "Heath" + Heath;
        
        speed = 4;
	}

    // Update is called once per frame
    void Update() {
        if(Speedy<=0)
        {
            Speedy = 0;
            PlayerPrefs.SetFloat("Boost", Speedy);
            speed = 4;
        }
      
       
            Speedy = PlayerPrefs.GetFloat("Boost", Speedy);
            Heath = PlayerPrefs.GetInt("Heath", Heath);
            counter = PlayerPrefs.GetInt("level", counter);
            Keys = PlayerPrefs.GetInt("keys", Keys);
            HeathText.text = "Heath" + Heath;
            BoostLeft.text = "Boost" + Speedy;
        
     //if (Checkpoint == true)
     //{
     //   counter= PlayerPrefs.GetInt("Checkpoint2", counter);
     //   Heath= PlayerPrefs.GetInt("Checkpoint", Heath);
     //    Speedy=PlayerPrefs.GetFloat("Checkpoint1", Speedy);
     //    Keys=PlayerPrefs.GetInt("Checkpoint3", Keys);
     //    PlayerPrefs.SetInt("level", counter);
     //      PlayerPrefs.SetFloat("Boost", Speedy);
     //      PlayerPrefs.SetFloat("Heath", Heath);
     //     PlayerPrefs.SetFloat("keys", Keys);
     //    HeathText.text = "Heath" + Heath;
     //    BoostLeft.text = "Boost"+Speedy;
     //        }
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
        if (Input.GetKeyDown("space")&&Speedy>0)
        {
           
            PlayerPrefs.SetFloat("Boost", Speedy);
            BoostLeft.text = "Boost" + Speedy;

            dragon = true;
            dragon3 = true;
        }
      
        if (opendoor==true)
        {
            Subdoor.GetComponent<BoxCollider>().enabled = false;
            Subdoor.GetComponent<MeshRenderer>().enabled = false;
        }
        if (dragon == true&&Speedy+1500>=fakespeedy)
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
     
        
        if (dragon2==true)
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
   

        if (Speedy +1500 <= fakespeedy || Input.GetKeyDown(KeyCode.A))
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
      
        if (Player.transform.position.y < -4 && Heath != 0&&Checkpoint==false)
        {
            Player.transform.position = Destination.transform.position;

        }
        if (Player.transform.position.y < -4 && Heath != 0 && Checkpoint == true)
        {
            Player.transform.position = NewArea1.transform.position;

        }

        if (Input.GetKey("escape"))
        {
            Checkpoint = false;
            counter = 0;
            Speedy = 0;
            Heath = 5;
            Keys = 0;
            PlayerPrefs.SetInt("Heath", Heath);
            PlayerPrefs.SetFloat("Boost", Speedy);
            PlayerPrefs.SetInt("level", counter);
            Application.Quit();
        }
        if (Heath <= 0&&Checkpoint==false)
        {
            Keys = 0;
            counter = 0;
            Speedy = 0;
            Heath = 5;
            PlayerPrefs.SetInt("keys", Keys);
            PlayerPrefs.SetInt("Heath", Heath);
            PlayerPrefs.SetFloat("Boost", Speedy);
              PlayerPrefs.SetInt("level", counter);
            SceneManager.LoadScene(LoadbyLevl);
        }
        if (Heath <= 0 && Checkpoint == true)
        {
            Keys = PlayerPrefs.GetInt("Checkpoint3", Keys);
            counter = 1;
            Speedy = PlayerPrefs.GetFloat("Checkpoint1", Speedy);
            Heath = PlayerPrefs.GetInt("Checkpoint", Heath);
            PlayerPrefs.SetInt("keys", Keys);
            PlayerPrefs.SetInt("Heath", Heath);
            PlayerPrefs.SetFloat("Boost", Speedy);
            PlayerPrefs.SetInt("level", counter);
            Player.transform.position = NewArea1.transform.position;

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atk1"|| other.gameObject.tag == "Atk2")
        {
           
            Heath--;
            PlayerPrefs.SetInt("Heath", Heath);
        }
     
        if (other.gameObject.tag=="Enemy")
        {
            
            Heath--;
            PlayerPrefs.SetInt("Heath", Heath);
        }
     
        if (other.gameObject.tag == "SpeedBoost" )
        {
            Speedy+=6000;
            PlayerPrefs.SetFloat("Boost", Speedy);
          
        }
     
        if (other.gameObject.tag == "HeathBonus")
        {
            Heath++;
            PlayerPrefs.SetInt("Heath", Heath);
        }
     
        
        if (other.gameObject.tag == "Door" && Keys >= 1)
        {
            Keys--;
            Door.GetComponent<BoxCollider>().enabled = false;
            Door.GetComponent<MeshRenderer>().enabled = false;
            opendoor = true;
            PlayerPrefs.SetInt("keys", Keys);
        }
        if (other.gameObject.tag == "Levelload")
        {
            counter++;
            PlayerPrefs.SetInt("level", counter);
        }
        if (other.gameObject.tag == "NewArea")
        {
            Checkpoint = true;
            PlayerPrefs.SetInt("Checkpoint2", counter);
            PlayerPrefs.SetInt("Checkpoint", Heath);
            PlayerPrefs.SetFloat("Checkpoint1", Speedy);
            PlayerPrefs.SetInt("Checkpoint3", Keys);
            Player.transform.position = NewArea1.transform.position;

        }
        if (other.gameObject.tag == "indungon")
        {
            fakenumber = 1;
            PlayerPrefs.SetInt("dungon", fakenumber);
        }
    }
    public bool GetDragon()
    {
        return dragon;
    }
    public int GetCounter()
    {
        counter = PlayerPrefs.GetInt("level", counter);
        return counter;
    }
    public int GetDungonStatus()
    {
        fakenumber = PlayerPrefs.GetInt("dungon", fakenumber);
        return fakenumber;
    }
    
}
