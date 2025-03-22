using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CALCULATOR : MonoBehaviour {
[SerializeField] private TMP_InputField inputField1;
    [SerializeField] private TMP_InputField inputField2;
    [SerializeField] private TMP_Text OutputText;
    public void OnButtonMinus() {
        float value1 = ReadFloatFromInputField(inputField1);
        float value2 = ReadFloatFromInputField(inputField2);
        OutputText.text = (value1 - value2).ToString();
    }

    public void OnButtonPlus() {
        float value1 = ReadFloatFromInputField(inputField1);
        float value2 = ReadFloatFromInputField(inputField2);
        OutputText.text = (value1 + value2).ToString();
    }

    public void OnButtonMultiplication() {
        float value1 = ReadFloatFromInputField(inputField1);
        float value2 = ReadFloatFromInputField(inputField2);
        OutputText.text = (value1 * value2).ToString();
    }
    public void OnButtonDivision() {
        float value1 = ReadFloatFromInputField(inputField1);
        float value2 = ReadFloatFromInputField(inputField2);
        OutputText.text = (value1 / value2).ToString();
    }

    private float ReadFloatFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length > 0) {
            if (float.TryParse(str, out float floatValue)) {
                return floatValue;
            }
        }
        return 0;
    }
}
