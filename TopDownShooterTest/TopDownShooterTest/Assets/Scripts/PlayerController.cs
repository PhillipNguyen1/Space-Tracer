using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; //determines how fast player moves
    private Rigidbody myRigidBody;  //apply forces so player can move around

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    //camera references
    private Camera mainCamera;

    public GunController theGun;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        // More responsive movement
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        //camera to mouse interaction
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        //create another plane
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        //raycast (determine lenght of particular ray; if camera hits anything else in our world)
        if(groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            //make player look at what we (the mouse) is pointing at
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));

        }

        //left mouse button to fire
        if (Input.GetMouseButtonDown(0))
        {
            theGun.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            theGun.isFiring = false;
        }
	}

    // apply input and speed to rigidbody component
    void FixedUpdate() {
        myRigidBody.velocity = moveVelocity;
    }
}
