using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float playerMovement = 700f;
    public float forwardForce = 2000f;
	
	// Update is called once per frame
	void FixedUpdate () {
        // Add a forward force
        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, playerMovement * Time.deltaTime);
        }

        if (Input.GetKey("s")) {
            rb.AddForce(0, 0, (-playerMovement / 2) * Time.deltaTime);
        }

        if (Input.GetKey("d")) {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

	}
}
