
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Practic6 : MonoBehaviour
{
    public float countdown = 60f;
    private float currentTime;
    public TMP_Text timerText;
    public Image image;
    private bool StopTime = false;

    void Start()
    {
        image.gameObject.SetActive(false);
        currentTime = countdown; 
        UpdateTimerText();
        StopTime = true;
    }

    void Update()
    {
        if (StopTime)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                StopTime = false;
                Debug.Log("ТЫ ПРОИГРАЛ");
                image.gameObject.SetActive(true);
            }

            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        timerText.text = currentTime.ToString("F1");
    }
}