using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletHit : NetworkBehaviour {

	public float power;

	void Start(){
		if(!isServer){
			this.enabled = false;
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(!isServer){
			return;
		}

		if(col.gameObject.tag == "Player"){
			GameObject _target = col.gameObject;
			Hit(_target);
		}
	}

	
	void Hit(GameObject _target){
		Debug.Log(_target.name + " was hit");
		if(_target.GetComponent<PlayerHealth>()){

			//_target.GetComponent<PlayerHealth>().TakeDamage(power);
			_target.GetComponent<PlayerHealth>().DeductHealth(power);
		}
	}

}
