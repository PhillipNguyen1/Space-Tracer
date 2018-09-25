using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", move);
            anim.SetTrigger("Move");
            float move2 = Input.GetAxis("Vertical");
            anim.SetFloat("Speed", move2);
            anim.SetTrigger("Move");
        }
	}

    //update: probably won't need transform.eulerAngles (still not sure)
    void Movement()
    {
        if(Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(Vector3.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Translate(Vector3.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, -180);
        }
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(Vector3.up * 3f * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            transform.Translate(Vector3.down * 3f * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
}
