using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using TMPro;

public class countdownTimer1 : MonoBehaviour
{
    public int countdownTime;
    public GameObject car;
    public GameObject car2;
    public GameObject car3;
    public TextMeshProUGUI countdownDisplay;
    public TextMeshProUGUI pressAnyKey;
    bool pressed = false;

    void Start()
    {
        
    }

    private void Update() {
        if (Input.anyKeyDown && !pressed)
        {
            StartCoroutine(CountdownToStart());
        }
    }

    IEnumerator CountdownToStart(){
        pressAnyKey.gameObject.SetActive(false);
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        countdownDisplay.text = "GO!";
        car.GetComponent<timer1>().enabled = true;
        car.GetComponent<CarUserControl>().enabled = true;
        car2.GetComponent<CarAIControl>().enabled = true;
        car3.GetComponent<CarAIControl>().enabled = true;
        
        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        pressed = true;
    }
}
