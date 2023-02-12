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
                    inputArray1[j] = inputArray1[j - 1];
                    inputArray1[j - 1] = temp;
                }
            }
        }
        return inputArray1;
    }

    public static int[] QuickSort(this int[] inputArray2, int leftBorder, int rightBorder)
    {
        int i = leftBorder;
        int j = rightBorder;
        int temp = 0;
        int mid = ((leftBorder + rightBorder) / 2);
        if (inputArray2[mid] < inputArray2[i])
        {
            temp = inputArray2[mid];
            inputArray2[mid] = inputArray2[i];
            inputArray2[i] = temp;
        }
        if (inputArray2[rightBorder] < inputArray2[leftBorder])
        {
            temp = inputArray2[rightBorder];
            inputArray2[rightBorder] = inputArray2[leftBorder];
            inputArray2[leftBorder] = temp;
        }
        if (inputArray2[rightBorder] < inputArray2[mid])
        {
            temp = inputArray2[rightBorder];
            inputArray2[rightBorder] = inputArray2[mid];
            inputArray2[mid] = temp;
        }
        int pivot = inputArray2[mid];
        while (inputArray2[i] < pivot) i++;
        while (inputArray2[j] > pivot) j--;
        if (i <= j)
        {
            temp = inputArray2[i];
            inputArray2[i] = inputArray2[j];
            inputArray2[j] = temp;
            i++;
            j--;
        }
        if (i < rightBorder) QuickSort(inputArray2, i, rightBorder);
        if (j > leftBorder) QuickSort(inputArray2, leftBorder, j);
        return inputArray2;
    }
}