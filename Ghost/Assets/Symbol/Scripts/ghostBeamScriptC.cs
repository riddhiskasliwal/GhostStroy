﻿using UnityEngine;
using System.Collections;

public class ghostBeamScriptC : MonoBehaviour {

	public int speed = 5;
	//Shoots a beam from the ghost
	void Start () {
		Rigidbody2D ghostBeam = GetComponent<Rigidbody2D>();
		ghostBeam.velocity = new Vector2(speed, 0); 

		Destroy(gameObject, 15);
	}
}
