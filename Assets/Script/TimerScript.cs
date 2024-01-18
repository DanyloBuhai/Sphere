using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timer = 0;
    public TextMeshProUGUI timerText;
    float sec = 0, min = 0;
    void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        sec += Time.deltaTime;
        if (sec > 59.5f)
        {
            sec = 0;
            min++;
        }
        if (sec < 9.5f)
        {
            timerText.text = "0" + Mathf.Round(min) + " : 0" + Mathf.Round(sec);
        }
        else
        timerText.text = "0" + Mathf.Round(min) + " : " + Mathf.Round(sec);
    }
}
