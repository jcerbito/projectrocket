using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRocket : MonoBehaviour {

	Rigidbody _rigidbody;

	

	void Start () {
		_rigidbody = GetComponent<Rigidbody>();

 	}

	void Update () {
		ProcessInput();
	}

	private void ProcessInput(){
		if (Input.GetKey(KeyCode.Space)){
			print ("Rocket up!!");
			_rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 45);
			
		}
		if (Input.GetKey(KeyCode.A)){
			print ("Rocket left!!");
			transform.Rotate(Vector3.forward * Time.deltaTime * 100);
		}
		if (Input.GetKey(KeyCode.D)){
			print ("Rocket right!!");
			transform.Rotate(-Vector3.forward * Time.deltaTime * 100);
		}
	}

	


}
