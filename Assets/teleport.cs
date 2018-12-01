using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	void OnTriggerEnter( Collider zCzym){
		GameObject trigger = GameObject.Find ("Trigger2");
		if (zCzym.tag == "Player") {
			print ("Działa");
			zCzym.transform.position = trigger.transform.position;
			//zCzym.transform.position.x = trigger.transform.position.x;
			//zCzym.transform.position.z = trigger.transform.position.z;
			print ("trigger position: "+ trigger.transform.position);
		}else {
			print ("Nie działa");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}