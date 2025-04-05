using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
public class Practic2 : MonoBehaviour
{
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }
    private int SumEvenNumbersInArray(int[] array)
    {
        int total = 0;
        foreach (int value in array)
        {
            if(value % 2 == 0)
            {
                total = total + value;
                Debug.Log("value:" + value);
            }
            
        }
        return total;
    }
}
