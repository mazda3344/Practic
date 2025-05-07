using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class practic7 : MonoBehaviour
{
    public float MaxTime;
    private Image img;
    private float currentTime;

    void Start()
    {
        img = GetComponent<Image>();
        currentTime = MaxTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
            currentTime = MaxTime;
        
        img.fillAmount = currentTime / MaxTime;
    }
}
