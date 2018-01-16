using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour {
 
	void Start () {
		print(transform.position);
	}
	
	void OnTriggerEnter(Collider hit){
		if (hit.gameObject.CompareTag("Obstacle")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
