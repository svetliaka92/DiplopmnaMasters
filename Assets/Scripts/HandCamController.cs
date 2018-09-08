using System.Collections;
using UnityEngine;

public class HandCamController : MonoBehaviour
{
    public GameObject handCam;

    void OnEnable()
    {
        StartCoroutine(HandCamDeactivator());
    }

    IEnumerator HandCamDeactivator()
    {
        yield return new WaitForSeconds(18f);
        this.gameObject.SetActive(false);
    }
}
