using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed; //bullet speed

    public float lifTime; //bullet lifspan (so that bullet objects don't stay in game forever)(object pooling)
    public int damageToGive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform tells object to move to new position
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifTime -= Time.deltaTime;
        if(lifTime <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter (Collision other){
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Destroy(gameObject);
        }
    }
}
