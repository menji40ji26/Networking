using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Spawn : NetworkBehaviour {

	public GameObject objectToSpawn;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if(!isLocalPlayer){
			return;
		}
		if(Input.GetKey(KeyCode.F)){
			CmdSpawn();
		}
	}

	[Command]
	void CmdSpawn(){
		GameObject go = Instantiate(objectToSpawn, spawnPoint);
		NetworkServer.Spawn(go);
		go.transform.parent = null;
		go.GetComponent<BulletFly>().Fly(spawnPoint.position);
		Destroy(go, 2);
	}
}
