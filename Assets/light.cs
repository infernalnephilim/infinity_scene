using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {

	void OnTriggerEnter( Collider zCzym){
		if (zCzym.tag == "Trigger") {
			print ("Działa");


		}else {
			print ("Nie działa");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
