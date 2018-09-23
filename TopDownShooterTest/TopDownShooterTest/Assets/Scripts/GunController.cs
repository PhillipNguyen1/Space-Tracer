using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    
    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint; //where bullet will fire from.
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                //firing rate (will be different for different guns)
                shotCounter = timeBetweenShots;
                //Makes clone of bullet prefab, makes new instance of game object
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
	}
    
}
