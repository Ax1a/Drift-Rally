using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class carSpeed : MonoBehaviour
{
    public TextMeshProUGUI speedLabel;
    public GameObject car;
    void Update()
    {
        CarController carController = car.GetComponent<CarController>();
        speedLabel.text = carController.CurrentSpeed.ToString("F0") + " mph";
    }
}
