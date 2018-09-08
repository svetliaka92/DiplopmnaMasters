using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFistDetect : MonoBehaviour
{
    ThalmicMyo myo;
    public GameObject gratzPanel;

    void Start()
    {
        myo = GameObject.FindObjectOfType<ThalmicMyo>();
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Fist Done!");
    }

    void Update()
    {
        if(myo.pose == Thalmic.Myo.Pose.Fist)
        {
            Debug.Log("Made fist. Congratualtions!");
            gratzPanel.gameObject.SetActive(true);
        }
    }
}
