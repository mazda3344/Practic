
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Practic6 : MonoBehaviour
{
    public TMP_Text TimerText;
    private float currentTime;
    public float countdown = 60f;
    void Start()
    {
        currentTime = countdown;
    }
    void Update()
    {
        currentTime -= Time.deltaTime;
        TimerText.text = currentTime.ToString();
        if (currentTime <= 0) 
        {
            currentTime = countdown;
        }
    }
}