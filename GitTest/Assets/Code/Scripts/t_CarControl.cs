using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_CarControl : MonoBehaviour {

    public float motorForce, steerForce, brakeForce;
    public WheelCollider F_L_Wheel, F_R_Wheel, R_L_Wheel, R_R_Wheel;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float v = Input.GetAxis("Vertical") * motorForce;
        float h = Input.GetAxis("Horizontal") * steerForce;

        R_R_Wheel.motorTorque = v;
        R_L_Wheel.motorTorque = v;

        F_R_Wheel.steerAngle = h;
        F_L_Wheel.steerAngle = h;

        if (Input.GetKey("s"))
        {
            R_L_Wheel.brakeTorque = brakeForce;
            R_R_Wheel.brakeTorque = brakeForce;
        }
        else
        {
            R_L_Wheel.brakeTorque = 0;
            R_R_Wheel.brakeTorque = 0;
        }

        if (Input.GetAxis("Vertical") == 0)
        {
            R_L_Wheel.brakeTorque = brakeForce;
            R_R_Wheel.brakeTorque = brakeForce;
        }
        else
        {
            R_L_Wheel.brakeTorque = 0;
            R_R_Wheel.brakeTorque = 0;
        }

	}
}
