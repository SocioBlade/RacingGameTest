using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O45rotStop : MonoBehaviour {

    public Rigidbody pRb;
    //public Vector3 rotVec;
    // Use this for initialization
    public Transform tLook;

	void Start ()
    {
        //pRb = GetComponent<Rigidbody>();
        //rotVec = new Vector3(pRb.rotation.x, pRb.rotation.y, -0.3f);

    }
	
	// Update is called once per frame
	void Update ()
    {
        print(gameObject.transform.rotation.eulerAngles.z);
        if (gameObject.transform.rotation.eulerAngles.z >= 45)
        {
            
        //    print("WHA!?");
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, 45);
        }
        else if (gameObject.transform.rotation.eulerAngles.z <= -90)
        {
            transform.Rotate(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, 0f);
            //    print("WHA!?");
            //    transform.Rotate(transform.rotation.x, transform.rotation.y, 45);
        }
        //else if (tLook.rotation.z <= -45)
        //{
        //    print("NEGATIVE WHA!?");
        //    transform.Rotate(transform.rotation.x, transform.rotation.y, -45);
        //}

        //if ((GetComponent<Rigidbody>().rotation.z <= -0.3))
        //{
        //    rotVec = new Vector3(pRb.rotation.x, pRb.rotation.y, -0.3f);
        //    Quaternion deltaRotation = Quaternion.Euler(rotVec * Time.deltaTime);
        //    pRb.MoveRotation(pRb.rotation * deltaRotation);
        //}
        //print(GetComponent<Rigidbody>().rotation.z);
    }
}
