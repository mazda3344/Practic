    using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class Practic62 : MonoBehaviour
{
    public TMP_Text Text1;
    public TMP_Text Text2;
    public TMP_Text Text3;
    private int number1;
    private int number2;
    private int number3;

    void Start()
    {
        number1 = 1;
        number2 = 1;
        number3 = 1;
        UpdateText();
    }
    void Update()
    {
        number1 += 1;
        number2 -= 1;
        number3 += 0;
        UpdateText();

    }
    private void UpdateText()
    {
        Text1.text =  number1.ToString();
        Text2.text = number2.ToString();
        Text3.text = number3.ToString();
    }
}
 