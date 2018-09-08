using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyoData : MonoBehaviour
{
    public Text accText;
    public Text gyroText;

    ThalmicMyo myo;

    // Use this for initialization
    void Start()
    {
        myo = GameObject.FindObjectOfType<ThalmicMyo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myo)
        {
            accText.text = myo.accelerometer.ToString();
            gyroText.text = myo.gyroscope.ToString();
        }
    }
}
