﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class GyroLookAround : MonoBehaviour {

	// Use this for initialization
	void Start () {

        VRSettings.enabled = true;

    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);

    }
}
