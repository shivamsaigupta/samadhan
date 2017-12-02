using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (SystemInfo.supportsGyroscope)
        {
            print("Gyro detected");
            SceneManager.LoadScene("VR");

        }
        else {
            print("No Gyro");
            SceneManager.LoadScene("NonVR");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
