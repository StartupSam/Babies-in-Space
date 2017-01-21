﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed = 15f;
    public GameObject shooter;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        Destroy(gameObject, 5.0f);

    }
}
