using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class controlTimer1 : MonoBehaviour {
	public TextMeshProUGUI bestLapLabel;
	public TextMeshProUGUI currentLap;
	public TextMeshProUGUI position;
	public GameObject panel1;
	public int curPosition = 1;
	private bool check;
	private bool lapCheck;
	private int lap = 1;
	private float bestLap = 0f;
	// public int timeNum;
	
	private void Start() {
		setTimer(1);
	}

	void OnTriggerEnter(Collider hit) {
		if(hit.tag.Equals("Checkpoint") && !check)
		{
			position.SetText(curPosition + "/3");
			check = true;
			// reduceTimer(5);
		}
		
		else if(hit.tag.Equals("resetEnter")){
			check = false;
		}

		else if(hit.tag.Equals("Checkpoint2") && !check)
		{
			position.SetText(curPosition + "/3");
			check = true;
			// reduceTimer(5);
		}

		else if (hit.tag.Equals("resetEnter2")){
            check = false;
			lapCheck = true;
        }
		else if (hit.tag.Equals("lap") && lapCheck){
			timer playerTimer = this.GetComponent<timer>();
			position.SetText(curPosition + "/3");
			lap += 1;
			lapCheck = false;
			if (lap <= 3){
				// reduceTimer(10);
				currentLap.SetText(lap + "/3");
			}
			check = false;
			
			if(lap > 3 && curPosition == 1){
				panel1.GetComponent<menuDisplay>().displayMenu("Mission Success!");
			}
			else if (lap > 3 && curPosition > 1){
				panel1.GetComponent<menuDisplay>().displayMenu("Mission Failed!");
			}

			
			// Reset lap
			if (playerTimer.time < bestLap || bestLap == 0f){
				bestLap = playerTimer.time;
				playerTimer.time = 0;
				Debug.Log(bestLap);
				int minutes = Mathf.FloorToInt(bestLap / 60F);
				int seconds = Mathf.FloorToInt(bestLap - minutes * 60);
				bestLapLabel.text = string.Format("{0:00}:{1:00}", minutes, seconds);
			}
		}
	}

	void setTimer(int t){
		timer1 playerTimer = this.GetComponent<timer1>();
		playerTimer.startTimer = t;
	}

	// void reduceTimer(float reduceTime){
	// 	timer playerTimer = this.GetComponent<timer>();
	// 	playerTimer.time -= reduceTime;
	// 	check = true;
	// }
}