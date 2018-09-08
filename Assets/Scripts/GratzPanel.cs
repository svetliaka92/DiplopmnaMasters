using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GratzPanel : MonoBehaviour
{
    public Text gratzText;

    public GameObject raiseArmPanel;
    public GameObject makeFistPanel;

    public ExersiceTimer exTimer;
    float timer;

    void Start()
    {
        
    }

    void OnEnable()
    {
        timer = exTimer.GetExTimer();

        StartCoroutine(DeactivateGratzPanel());

        if (raiseArmPanel.activeInHierarchy)
        {
            raiseArmPanel.SetActive(false);
        }

        if (makeFistPanel.activeInHierarchy)
        {
            makeFistPanel.SetActive(false);
        }

        gratzText.text = "Good job!\nYou have completed the exersice in " + timer + " seconds";

        string theTime = System.DateTime.Now.ToString("hh:mm:ss");
        string theDate = System.DateTime.Now.ToString("dd/MM/yyyy");
        string str = "Date: " + theDate + " at: " + theTime + ". Rezult for exercise: " + timer + " seconds.";
        // open file
        StreamWriter sw = new StreamWriter("log.txt", true);
        // write str to xml/txt file
        sw.WriteLine(str);
        // close file
        sw.Close();
    }

    IEnumerator DeactivateGratzPanel()
    {
        yield return new WaitForSeconds(15f);
        this.gameObject.SetActive(false);
    }
}
