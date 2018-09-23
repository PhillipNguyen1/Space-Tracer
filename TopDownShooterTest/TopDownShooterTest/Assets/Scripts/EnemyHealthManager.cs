using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int health;  //total health
    private int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

    // determines how much damage are we going to do to our enemy
    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
