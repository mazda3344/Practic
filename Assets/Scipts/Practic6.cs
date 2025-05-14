using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using System;
using UnityEngine.Timeline;
using System.Drawing;
using UnityEditor;
public class Practic6Pin : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public int pin1 = 1;
    public int pin2 = 1;
    public int pin3 = 1;
    public TMP_Text pin_1text;
    public TMP_Text pin_2text;
    public TMP_Text pin_3text;
    public float countdown = 60f;
    private float currentTime;
    public TMP_Text timerText;
    public Image image;
    private bool StopTime = false;
    public Image imageh;
    public Button buttonWin;
    public Button ButtonDontWin;
    public AudioSource audio;
    public AudioClip clip1;
    public AudioClip clip2;

    void Start()
    {
        button1.onClick.AddListener(OnButtonClick1);
        button2.onClick.AddListener(OnButtonClick2);
        button3.onClick.AddListener(OnButtonClick3);
        buttonWin.onClick.AddListener(OnButtonClick4);
        ButtonDontWin.onClick.AddListener(OnButtonClick5);
        image.gameObject.SetActive(false);
        imageh.gameObject.SetActive(false);
        currentTime = countdown; 
        UpdateTimerText();
        StopTime = true;
        audio.Play();
    }
    public void changeSound()
        {
            if(audio.isPlaying)
              audio.Pause();
                else
                audio.Play();
            
        }
    void OnButtonClick1()
    {
        pin1 += 1;
        pin2 -= 1;
        pin3 += 0;
        ResetText();
        
    }
    void OnButtonClick2()
    {
        pin1 -= 1;
        pin2 += 2;
        pin3 -= 1;
        ResetText();
    }
    void OnButtonClick3()
    {
        pin1 -= 1;
        pin2 += 1;
        pin3 += 1;
        ResetText();
    }
    void ResetText()
    {
        pin_1text.text = pin1.ToString();
        pin_2text.text = pin2.ToString();
        pin_3text.text = pin3.ToString();
    }
    void OnButtonClick4()
    {
        pin1 = 1;
        pin2 = 1;
        pin3 = 1;
        ResetText();
        image.gameObject.SetActive(false);
        imageh.gameObject.SetActive(false);
        currentTime = 60f;
        StopTime = true;
        audio.Play();
    }
    void OnButtonClick5()
    {
        
        pin1 = 1;
        pin2 = 1;
        pin3 = 1;
        ResetText();
        image.gameObject.SetActive(false);
        imageh.gameObject.SetActive(false);
        currentTime = 60f;
        StopTime = true;
        audio.Play();
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
            if (pin1 == 7 && pin2 == 7 && pin3 == 7)
            {
                StopTime = false;
                Debug.Log("ТЫ ПОБЕДИЛ");
                imageh.gameObject.SetActive(true);
                
            }
            if (pin1 >= 20 || pin2 >= 20 || pin3 >= 20)
            {
                StopTime = false;
                Debug.Log("ТЫ ПРОИГРАЛ");
                image.gameObject.SetActive(true);
                
            }
            if (pin1 <= -20 || pin2 <= -20 || pin3 <= -20)
            {
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