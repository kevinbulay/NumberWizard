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
        min = 1;
        max = 1000;
        guess = 500;
        
        Debug.Log("I$T DA$$ DEINE ZAHL " + guess + "?");
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
        Debug.Log("FOLGT @PANZERBANDE");
        }

	}
    void Vermutung ()
    {
        guess = (min + max) / 2;
        Debug.Log("I$T DA$$ DEINE ZAHL " + guess + "?");
        
    }
}
