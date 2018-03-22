using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Player))]
public class PlayerSetup : NetworkBehaviour {

	public PlayerList pl;

	// Use this for initialization
	void Start () {
		if(isServer){
			transform.name = "Player " + GetComponent<NetworkIdentity>().netId.ToString();
			pl = GameObject.Find("PlayerList").GetComponent<PlayerList>();
			pl.AddPlayer("Player " + GetComponent<NetworkIdentity>().netId.ToString(), gameObject);
		}
	}

	public override void OnStartClient(){
		base.OnStartClient();
		string _netID = GetComponent<NetworkIdentity>().netId.ToString();
		Player _player = GetComponent<Player>();
		GameManager.RegisterPlayer(_netID, _player);
	}

	void OnDisable (){

		GameManager.UnRegisterPlayer(transform.name);
	}
}
