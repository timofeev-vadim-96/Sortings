public static class Sorting
{
    public static int[] SortSelection(this int[] inputArray) // СОРТИРОВКА ВЫБОРОМ
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int pos = i;
            for (int l = i + 1; l < inputArray.Length; l++)
            {
                if (inputArray[l] < inputArray[pos])
                {
                    pos = l; //запоминаем позицию минимального элемента в массиве
                }
            }
            int temp = inputArray[i]; // запоминаем число на позиции i
            inputArray[i] = inputArray[pos]; // перемещаем минимальный элемент на i позицию
            inputArray[pos] = temp; // окончательно меняем числа местами
        }
        return inputArray;
    }

    public static int[] BubbleSorting(this int[] inputArray1) // ПУЗЫРЬКОВАЯ СОРТИРОВКА
    {
        for (int i = 0; i < inputArray1.Length; i++)
        {
            for (int j = 1; j < inputArray1.Length - i; j++)
            {
                if (inputArray1[j] < inputArray1[j - 1])
                {
                    int temp = inputArray1[j];
                    inputArray1[j] = inputArray1[j-1];
                    inputArray1[j-1] = temp;
                }
            }
        }
        return inputArray1;
    }
}