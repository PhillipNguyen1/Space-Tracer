using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    //make reference to enemy rigidbody so we can modify its velocity
    private Rigidbody myRB;

    public float moveSpeed;

    //what is the enemy's target??
    public PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>(); //find rigidbody that's attached to enemy
        thePlayer = FindObjectOfType<PlayerController>(); //self - explanatory



	}
    //**Note: when we want to move any object within our world that has a 'rigidbody' attached to it
    //we want to do it in (FixedUpdate) function, rather than update.
	

    void FixedUpdate(){
        myRB.velocity = (transform.forward * moveSpeed);
    }
    
	// Update is called once per frame
	void Update () {
        transform.LookAt(thePlayer.transform.position); //follows player's current position

	}
}
