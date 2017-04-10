using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ThemagicCarpet : MonoBehaviour {
    float speed = 4;
    float rotating = 0;
    public int Heath = 5;
    public int Sticky = 0;
   public bool dragon = false;
   public float counter = 0;
    public GameObject Destination;
    public GameObject Player;
    public string LoadbyLevl;
    public Text HeathText;
    
	// Use this for initialization
	void Start () {
        HeathText.text = "Heath" + Heath;
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
             {
            do
            {
                dragon = true;
                counter += Time.deltaTime;
            } while (counter <= 5);
            dragon = false;
            Sticky--;
        }


        HeathText.text = "Heath" + Heath;
        transform.Translate(speed * Input.GetAxis("Left") * Time.deltaTime, 0f, speed * Input.GetAxis("Down") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.y, rotating, rotating);
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
        if (other.gameObject.tag == "Sticky" )
        {
            Sticky++;
          
        } 
      
    }
    public bool GetDragon()
    {
        return dragon;
    }
    
}
