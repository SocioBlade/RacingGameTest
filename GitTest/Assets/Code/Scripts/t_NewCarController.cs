using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CarInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}

public class t_NewCarController : MonoBehaviour {

    public List<CarInfo> carInfoList; // List of the wheel pairs.
    public float maxMotorTorque;
    public float maxSteeringAngle;


	// Use this for initialization
	void Start () {
		
	}

    public void FixedUpdate()
    {
        //Player movement
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (CarInfo carInfo in carInfoList)
        {
            //Cheeck steering
            if(carInfo.steering == true)
            {
                carInfo.leftWheel.steerAngle = steering;
                carInfo.rightWheel.steerAngle = steering;
            }

            //Motor check
            if(carInfo.motor == true)
            {
                carInfo.leftWheel.motorTorque = motor;
                carInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}
