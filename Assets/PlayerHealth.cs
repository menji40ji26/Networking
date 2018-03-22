using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerHealth : NetworkBehaviour {

	public Text healthText;
	[SyncVar] public float health;

	void Start(){


		health = 1000f;
		healthBar = GameObject.Find("HealthBar").GetComponent<RectTransform>();
		healthBar.GetComponent<Image>().color = Color.red;
	}

	public override void OnStartLocalPlayer ()
	{
		healthText = GameObject.Find("HealthText").GetComponent<Text>();
		GetComponent<MeshRenderer>().material.color = Color.yellow;
		SetHealthText();
		//healthBar = GameObject.Find("HealthBar").GetComponent<RectTransform>();
		//healthBar.GetComponent<Image>().color = Color.red;
	}

	void Update(){
		// if(isLocalPlayer){
		// 	SetHealthText();	
		// }
		// CheckHealth();
		CheckHealth();
	}

	void CheckHealth(){
		if(health <= 0) {
			GetComponent<MeshRenderer>().material.color = Color.black;
			health = 0f;
		}
	}
	
	public void SetHealthText(){
		if(isLocalPlayer)
		healthText.text = "Health: " + health.ToString();
	}

	public void DeductHealth(float damage){
		health -= damage;
		SetHealthText();
	}
	
	    
	// public const int maxHealth = 100;
	// public const float maxHealth = 100;
    // [SyncVar]
    // public float currentHealth = maxHealth;
    public RectTransform healthBar;

    // public void TakeDamage(float amount)
    // {
    //     if (!isServer)
    //     {
    //         return;
    //     }
        
    //     currentHealth -= amount;
    //     if (currentHealth <= 0)
    //     {
    //         currentHealth = 0;
    //         Debug.Log("Dead!");
    //     }

    //     healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    // }

}
