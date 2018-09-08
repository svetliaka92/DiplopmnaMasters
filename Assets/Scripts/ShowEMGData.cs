using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class ShowEMGData : MonoBehaviour
{
    ThalmicMyo myo;
    public int[] emg;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;

    string str;
    string[] textStr = new string[8];

    int counter = 0;

    bool canStream = true;

    // Use this for initialization
    void Start()
    {
        myo = FindObjectOfType<ThalmicMyo>();
        // Debug.Log(myo);
        emg = myo.GetEMGData();
        Debug.Log(emg.Count());
    }

    // Update is called once per frame
    void Update()
    {
        emg = myo.GetEMGData();
        // Debug.Log(emg.Count());
        if(emg.Count() >= 8)
        {
            counter = 0;
            foreach(int item in emg)
            {
                str += item + "\t";
                textStr[counter] = item.ToString();
                counter++;
            }
        }

        if (canStream)
        {
            text1.text = textStr[0];
            text2.text = textStr[1];
            text3.text = textStr[2];
            text4.text = textStr[3];
            text5.text = textStr[4];
            text6.text = textStr[5];
            text7.text = textStr[6];
            text8.text = textStr[7];

            // open file
            StreamWriter sw = new StreamWriter("emgData3.txt", true);
            // write str to xml/txt file
            sw.WriteLine(str);
            // close file
            sw.Close();
            StartCoroutine(CD());
        }
        str = "";
    }

    IEnumerator CD()
    {
        canStream = false;
        yield return new WaitForSeconds(5f);
        canStream = true;
        yield break;
    }
}
