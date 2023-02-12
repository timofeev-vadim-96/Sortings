public static class Sorting
{
    public static int[] SortSelection(int[] inputArray) // СОРТИРОВКА ВЫБОРОМ
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

    public static int[] BubbleSorting(int[] inputArray1) // ПУЗЫРЬКОВАЯ СОРТИРОВКА
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

    public static int[] QuickSort(int[] inputArray2, int leftBorder, int rightBorder) // БЫСТРАЯ СОРТИРОВКА
    {
        int i = leftBorder;
        int j = rightBorder;
        int pivot = inputArray2[Random.Shared.Next(leftBorder, rightBorder)];
        while (inputArray2[i] < pivot) i++;
        while (inputArray2[j] > pivot) j--;
        if (i <= j) // в случае равенства нам фактически нужны будут только 51 и 52 строки кода, они же и нужны для 
        // выхода из рекурсии
        {
            int temp = inputArray2[i];
            inputArray2[i] = inputArray2[j];
            inputArray2[j] = temp;
            i++;
            j--;
        }
        if (i < rightBorder) QuickSort(inputArray2, i, rightBorder); // сортируется левая часть массива
        if (j > leftBorder) QuickSort(inputArray2, leftBorder, j); // сортируется правая часть массива
        return inputArray2;
    }

    static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    public static void QSort(int[] array, int firstIndex = 0, int lastIndex = -1) // Из интернета вариант
    {
        if (lastIndex < 0)
            lastIndex = array.Length - 1;
        if (firstIndex >= lastIndex)
            return;
        int middleIndex = (lastIndex - firstIndex) / 2 + firstIndex, currentIndex = firstIndex;
        Swap(ref array[firstIndex], ref array[middleIndex]);
        for (int i = firstIndex + 1; i <= lastIndex; ++i)
        {
            if (array[i] <= array[firstIndex])
            {
                Swap(ref array[++currentIndex], ref array[i]);
            }
        }
        Swap(ref array[firstIndex], ref array[currentIndex]);
        QSort(array, firstIndex, currentIndex - 1);
        QSort(array, currentIndex + 1, lastIndex);
    }


}
