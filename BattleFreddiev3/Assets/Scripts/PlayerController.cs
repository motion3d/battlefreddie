using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    public CharacterController controller;
    public float gravityScale = 1.0f;
    public Swipe swipeControls;
    private Vector3 desiredPosition;

    private Vector3 moveDirection;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        // moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);

        /*
        if (swipeControls.SwipeLeft)
            desiredPosition += Vector3.left;
        if (swipeControls.SwipeRight)
            desiredPosition += Vector3.right;
        if (swipeControls.SwipeUp)
            desiredPosition += Vector3.forward;
        if (swipeControls.SwipeDown)
            desiredPosition += Vector3.back;
        */

        if (swipeControls.SwipeLeft)
            Debug.Log("LEFT!!!");
        if (swipeControls.SwipeRight)
            Debug.Log("RIGHT!!!");
        if (swipeControls.SwipeUp)
            Debug.Log("UP!!!");
        if (swipeControls.SwipeDown)
            Debug.Log("DOWN!!!");

        if (swipeControls.Tap)
            Debug.Log("TAP!!!");



        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, 0f);

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection * Time.deltaTime);

	}
}
