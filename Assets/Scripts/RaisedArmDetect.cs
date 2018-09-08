using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaisedArmDetect : MonoBehaviour
{
    public GameObject gratzPanel;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Raised arm completed");
        gratzPanel.gameObject.SetActive(true);
    }
}
