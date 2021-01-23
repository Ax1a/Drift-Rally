using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;

public class checkLand : MonoBehaviour
{
    public WheelCollider WheelL;
    public WheelCollider WheelR;

    void Update()
    {
        StartCoroutine(slowTime());
    }

    IEnumerator slowTime(){
    //  private void FixedUpdate() {
        WheelR = GameObject.Find("WheelHubFrontRight").GetComponent<WheelCollider>();
        WheelL = GameObject.Find("WheelHubFrontLeft").GetComponent<WheelCollider>();
        WheelHit hit;
        bool GroundedR = WheelR.GetGroundHit(out hit);
        bool GroundedL = WheelL.GetGroundHit(out hit);

        if (GroundedR || GroundedL){
            if(hit.collider.tag == ("track"))
            {  
                CarController control = this.GetComponent<CarController>();
                yield return new WaitForSeconds(.3f);
                control.m_FullTorqueOverAllWheels = 1200;
                control.m_ReverseTorque = 250;
                control.m_Topspeed = 200;
            }
            else if(hit.collider.tag == ("grass"))
            {  
                CarController control = this.GetComponent<CarController>();
                yield return new WaitForSeconds(.3f);
                control.m_FullTorqueOverAllWheels = 400;
                control.m_ReverseTorque = 50;
                control.m_Topspeed = 20;
            }
        } 
    }
}
