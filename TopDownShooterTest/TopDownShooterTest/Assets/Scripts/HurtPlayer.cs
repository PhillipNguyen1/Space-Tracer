using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//how much damage are we going to do to the player?
public class HurtPlayer : MonoBehaviour {

    public int damageToGive; //can be used if player walks into other things that hurt him

    //when player walks into hurtbox, what happens
	public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
    
}
