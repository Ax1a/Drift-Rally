using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionCtr : MonoBehaviour
{
    public GameObject car;
    private bool check;
	private bool lapCheck;
    void OnTriggerEnter(Collider hit) {
		if(hit.tag.Equals("Checkpoint") && !check)
		{
			controlTimer1 playerTimer = car.GetComponent<controlTimer1>();
            playerTimer.curPosition += 1;
            check = true;
		}
		
		else if(hit.tag.Equals("resetEnter")){
			check = false;
            controlTimer1 playerTimer = car.GetComponent<controlTimer1>();
            playerTimer.curPosition = 1;
		}

		else if(hit.tag.Equals("Checkpoint2") && !check)
		{
            controlTimer1 playerTimer = car.GetComponent<controlTimer1>();
            playerTimer.curPosition += 1;
            check = true;
			// reduceTimer(5);
		}
        
        else if (hit.tag.Equals("resetEnter2")){
            lapCheck = true;
            controlTimer1 playerTimer = car.GetComponent<controlTimer1>();
            playerTimer.curPosition = 1;
        }

		else if (hit.tag.Equals("lap") && lapCheck){
            controlTimer1 playerTimer = car.GetComponent<controlTimer1>();
            playerTimer.curPosition += 1;
        }
    }
}
