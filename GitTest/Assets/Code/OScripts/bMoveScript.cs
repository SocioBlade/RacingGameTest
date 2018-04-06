using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bMoveScript : MonoBehaviour
{

    public float moveSpeed;
    //public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        moveSpeed = 10f;
	}

    // Update is called once per frame
    void Update ()
    {
        //rb.AddForce(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")* Time.deltaTime);
    }
}
