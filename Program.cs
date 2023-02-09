// Сортировка выбором
int[] basicArray = { 10, 4, 24, 65, 1, 23, 45, 63, 45, 1, 3, 15 };
void SortSelection(int[] inputArray)
{
    for (int i = 0; i < basicArray.Length - 1; i++)
    {
        int pos = i;
        for (int l = i + 1; l < basicArray.Length; l++)
        {
            if (basicArray[l] < basicArray[pos])
            {
                pos = l;
            }
        }
        int temp = basicArray[i];
        basicArray[i] = basicArray[pos];
        basicArray[pos] = temp;
    }
}
SortSelection(basicArray);
System.Console.WriteLine(String.Join(", ", basicArray));