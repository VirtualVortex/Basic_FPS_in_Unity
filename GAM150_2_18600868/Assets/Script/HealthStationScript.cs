using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStationScript : MonoBehaviour {

    //The script will allow the health station change colour when armed

    public bool armed;

    // Use this for initialization
    void Start () {
        armed = false;
        GetComponent<Renderer>().material.color = new Color(0, 244, 0);
    }
	
	// If the health station is armed then it will change colour
	void Update () {
        if (armed == true)
        {
            GetComponent<Renderer>().material.color = new Color(244, 0, 0);
        }
    }

    
}
