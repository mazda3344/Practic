using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomNumber : MonoBehaviour{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text outputText;
    private  int randomValue;
    private void Start() {
        GenerateRandomValue();
    }

    private void GenerateRandomValue() {
        randomValue = UnityEngine.Random.Range(0, 101);
    }
    public void OnButton() {
        int userEnterValue = ReadIntFromInputField(inputField);
        if (userEnterValue == randomValue) {
            outputText.text = "Ты угадал!";
            GenerateRandomValue();
        } else if (randomValue < userEnterValue) {
            outputText.text = "Загаданое число меньше!";
        } else {
            outputText.text = "Загаданое число больше!";
        }
    }
    private int ReadIntFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length > 0) {
            if (int.TryParse(str, out int intValue)) {
                return intValue;
            }
        }
        return 0;
    }
}
