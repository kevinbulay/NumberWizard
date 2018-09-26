using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min;
    int max;
    int guess;
	// Use this for initialization
	void Start () 
    {
        min = 15;
        max = 140;
        
        Debug.Log("MOIN$EN WIE GEHT$");
        
        Debug.Log("ICH BIN DER NUMBERWIZARD UND ICH WERDE DIR EINEN TRICK ZEIGEN");
        
        Debug.Log("DENKE AN EINE ZAHL ZWISCHEN " + min);
        Debug.Log("UND " + max);
        
        Vermutung();
        
        Debug.Log("BENUTZE DIE PFEILTASTE NACH OBEN UND UNTEN UM ZU ZEIGEN OB DEINE ZAHL HÖHER ODER NIEDRIGER IST");
        
        Debug.Log("WENN ICH DEINE ZAHL ERRATEN HABE DRÜCK ENTER");
    }
        
	// Update is called once per frame
	void Update () {
        //lower
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        max = guess;
            
            Vermutung();
        }
        
        //higher
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        min = guess;
            Vermutung();
        }
         else if (Input.GetKeyDown(KeyCode.Return))
        {
        Debug.Log("ICH HABE GEWONNEN");
        }

	}
    void Vermutung ()
    {
        guess = (min + max) / 2;
        Debug.Log("I$T DEINE ZAHL HÖHER ODER NIEDRIGER ALS " + guess + "?");
        
    }
}

