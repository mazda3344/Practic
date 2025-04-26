using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class practic6 : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
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

    void Start()
    {
        button1.onClick.AddListener(OnButtonClick1);
        button2.onClick.AddListener(OnButtonClick2);
        button3.onClick.AddListener(OnButtonClick3);
        button4.onClick.AddListener(OnButtonClick4);
        image.gameObject.SetActive(false);
        currentTime = countdown; 
        UpdateTimerText();
        StopTime = true;
    }
    void OnButtonClick1()
    {
        pin1 += 1;
        pin2 -= 1;
        pin3 += 0;
        pin_1text.text = pin1.ToString();
        pin_2text.text = pin2.ToString();
        pin_3text.text = pin3.ToString();
        
    }
    void OnButtonClick2()
    {
        pin1 -= 1;
        pin2 += 2;
        pin3 -= 1;
        pin_1text.text = pin1.ToString();
        pin_2text.text = pin2.ToString();
        pin_3text.text = pin3.ToString();

    }
    void OnButtonClick3()
    {
        pin1 -= 1;
        pin2 += 1;
        pin3 += 1;
        pin_1text.text = pin1.ToString();
        pin_2text.text = pin2.ToString();
        pin_3text.text = pin3.ToString();

    }
    void OnButtonClick4()
    {
        countdown = 60f;
        pin1 = 1;
        pin2 = 1;
        pin3 = 1;
        StopTime = true;
        pin_1text.text = pin1.ToString();
        pin_2text.text = pin2.ToString();
        pin_3text.text = pin3.ToString();

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
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        timerText.text = currentTime.ToString("F1");
    }
}