public static class Sorting
{
    public static int [] SortSelection(this int[] inputArray)
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
            inputArray[i] = inputArray[pos]; // минимальный элемент на i позицию
            inputArray[pos] = temp; // окончательно меняем местами числа
        }
        return inputArray;
    }
}