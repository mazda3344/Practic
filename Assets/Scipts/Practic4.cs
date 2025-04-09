
    using System.Linq;
    using UnityEngine;

    public class SelectionOfSort : MonoBehaviour
    {
        public void OnSelectionSort()
        {
            int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
            Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

            int[] sortedArray = SelectionSort((int[])originalArray.Clone());
            Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

            int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
            Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
        }
        private int[] SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
            return array;
        }
    }