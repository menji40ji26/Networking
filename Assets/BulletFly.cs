using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletFly : NetworkBehaviour {

	public float speed;

	
	// Update is called once per frame
	void Update () {
		
        transform.Translate(0f, 0f, speed);
	}

	public void Fly(Vector3 shootPoint){
		transform.position = shootPoint;
	}
}
