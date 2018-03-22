using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerList : NetworkBehaviour {

	public Dictionary<string, GameObject> players = new Dictionary<string, GameObject>();

	public void AddPlayer(string _name, GameObject player) {
		players.Add(_name, player);
	}

	public void RemovePlayer(string _name) {

		players.Remove(_name);
	}
}


