using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class practic7 : MonoBehaviour
{
    public float MaxTime1;
    public float MaxTime2;
    public float MaxTime3;
    public Image img1;
    public Image img2;
    public Image img3;
    private float currentTime1;
    private float currentTime2;
    private float currentTime3;
    public bool Tick;


    void Start()
    {
        currentTime1 = MaxTime1;
        currentTime2 = MaxTime2;
        currentTime3 = MaxTime3;
    }

    void Update()
    {
        Tick = false;
        currentTime1 -= Time.deltaTime;
        currentTime2 -= Time.deltaTime;
        currentTime3 -= Time.deltaTime;

        if (currentTime1 <= 0)
        {
            Tick = true;
            currentTime1 = MaxTime1;
        }
        img1.fillAmount = currentTime1 / MaxTime1;

        if (currentTime2 <= 0)
        {
            Tick = true;
            currentTime2 = MaxTime2;
        }
        img2.fillAmount = currentTime2 / MaxTime2;
        
        if (currentTime3 <= 0)
        {
            Tick = true;
            currentTime3 = MaxTime3;
        }
        img3.fillAmount = currentTime3 / MaxTime3;
        
    }
}
