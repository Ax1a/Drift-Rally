using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class timer1 : MonoBehaviour {
	public TextMeshProUGUI timerLabel;
	// public TextMeshProUGUI targetTimeLabel;
	public float startTimer = 0;
	public float time;
	// public float targetTime;
	// public int minutes2;
	// public int seconds2;
	
	void Update() {
		if (startTimer > 0) {
			time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			// minutes2 = Mathf.FloorToInt(targetTime / 60F);
			// seconds2 = Mathf.FloorToInt(targetTime - minutes2 * 60);
			// targetTimeLabel.text = string.Format("{0:00}:{1:00}", minutes2, seconds2);
			timerLabel.text = string.Format("{0:00}:{1:00}", minutes, seconds);
		} else {}
	}

}




