using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour {

	Vector3 StartPoint;
	
	void Start () {
		StartPoint = transform.position;
		print(transform.position);
	}
	
	void OnTriggerEnter(Collider obs){
		if (obs.gameObject.CompareTag("Obstacle")){
			transform.position = StartPoint;	
		}

	}
}
