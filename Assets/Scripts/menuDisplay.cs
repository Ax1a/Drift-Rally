using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using TMPro;

public class menuDisplay : MonoBehaviour
{
    public TextMeshProUGUI yourTime;
	public TextMeshProUGUI targetText;
    public TextMeshProUGUI stateText;
	public GameObject carObj;
	public GameObject panel;

    public void displayMenu(string s){
        timer playerTimer = carObj.GetComponent<timer>();
        CarController carController = carObj.GetComponent<CarController>();
		CarUserControl carUser = carObj.GetComponent<CarUserControl>();

		// Slow down Car
		carController.m_FullTorqueOverAllWheels = 0;
		carController.m_Topspeed = 20;

		// Disable Controls and Time
		carUser.isEnabled = false;
		carObj.GetComponent<timer>().enabled = false;

		// Convert time
        float playerBestTime = playerTimer.time;
		int minutes = Mathf.FloorToInt(playerBestTime / 60F);
		int seconds = Mathf.FloorToInt(playerBestTime - minutes * 60);
        
		// Set text to UI
		stateText.SetText(s);
		yourTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
		targetText.text = string.Format("{0:00}:{1:00}", playerTimer.minutes2, playerTimer.seconds2);
		panel.SetActive(true);
    }
}
