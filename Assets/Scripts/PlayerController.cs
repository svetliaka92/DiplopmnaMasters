using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ThalmicHub myoHub;
    public ThalmicMyo myo;

    public GameObject handCamera;
    public GameObject handCamPanel;

    public GameObject raiseArmPanel;
    public GameObject makeFistPanel;

    public GameObject exTimer;

    ExersiceTimer timer;

    // Use this for initialization
    void Start()
    {
        timer = exTimer.GetComponent<ExersiceTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateCamera()
    {
        handCamPanel.SetActive(true);
        handCamera.SetActive(true);
    }

    public void DeactivateCamera()
    {
        handCamPanel.SetActive(false);
        handCamera.SetActive(false);
    }

    public void ActivatePanel()
    {
        raiseArmPanel.SetActive(true);
    }

    public void ActivateFistPanel()
    {
        makeFistPanel.SetActive(true);
    }

    public void DeactivatePanel()
    {
        raiseArmPanel.SetActive(false);
    }

    public void DeactivateFistPanel()
    {
        makeFistPanel.SetActive(false);
    }

    public void StartExTimer()
    {
        timer.StartExTimer();
    }
}
