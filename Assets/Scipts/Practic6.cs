
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Practic6 : MonoBehaviour
{
    public TMP_Text TimerText;
    private float currentTime;
    private float countdown = 60f;
    void Start()
    {
        
    }
    void Update()
    {
        currentTime = Mathf.Round(Time.time);
        TimerText.text = currentTime.ToString();
    }
}