using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport4 : MonoBehaviour {

	void OnTriggerEnter( Collider zCzym){
		GameObject trigger = GameObject.Find ("Trigger8");
		if (zCzym.tag == "Player") {
			print ("Działa");
			zCzym.transform.position = trigger.transform.position;
			//zCzym.transform.position.x = trigger.transform.position.x;
			//zCzym.transform.position.z = trigger.transform.position.z;
			print ("trigger3 position: "+ trigger.transform.position);
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
