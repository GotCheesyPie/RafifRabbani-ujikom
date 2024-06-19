using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerUI : MonoBehaviour
{
    public TMP_Text timerText;
    float startTime = 60;
    float min = 0;

    // Update is called once per frame
    void Update()
    {
        min += Time.deltaTime;
        timerText.text = Mathf.FloorToInt(startTime - min).ToString();
    }
}
