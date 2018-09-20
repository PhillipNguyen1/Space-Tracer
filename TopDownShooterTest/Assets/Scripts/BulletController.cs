﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed; //bullet speed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform tells object to move to new position
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
