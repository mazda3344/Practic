using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class practic7 : MonoBehaviour
{
    public float MaxTime;
    public Image img1;
    private float currentTime;
    public bool Tick;


    void Start()
    {
        
        currentTime = MaxTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Tick = true;
            currentTime = MaxTime;
        }
        img1.fillAmount = currentTime / MaxTime;
    }
}
