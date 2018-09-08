using System.Collections;
using UnityEngine;

public class ExersiceTimer : MonoBehaviour
{
    float exTimer = 0.0f;
    bool record = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // keep recording if the value of record is true.
        // Time.delta time returns the time between the current and the previous frame in seconds
        if (record)
        {
            exTimer += Time.deltaTime;
        }
    }

    public void StartExTimer()
    {
        exTimer = 0.0f;
        record = true;
    }

    public float GetExTimer()
    {
        record = false;
        return exTimer;
    }
}
