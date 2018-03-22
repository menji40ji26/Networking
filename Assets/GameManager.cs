using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private const string PLAYER_ID_PREFIX = "Player ";

	private static Dictionary<string, Player> players = new Dictionary<string, Player>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}	
	
	public static void RegisterPlayer(string _netID, Player _player){
		string _playerID = PLAYER_ID_PREFIX + _netID;
		players.Add(_playerID, _player);
		_player.transform.name = _playerID;
	}

	public static void UnRegisterPlayer(string _playerID){
		players.Remove(_playerID);
	}

	public static Player GetPlayer(string _playerID){
		return players[_playerID];
	}


	void OnGUI(){
		GUILayout.BeginArea(new Rect(200, 200, 200, 500));
		GUILayout.BeginVertical();
		foreach (string _playerID in players.Keys){
			float _health = GameObject.Find(_playerID).GetComponent<PlayerHealth>().health;
			GUILayout.Label("[" + _playerID + "] HP " + _health);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
