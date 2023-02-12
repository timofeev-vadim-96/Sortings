using static Sorting;
using static Infrastructure;
using System.Diagnostics;
using static System.Console;
int[] array = CreateArray(10000, 0, 20);
// Show (array);
Stopwatch sw = new Stopwatch();
sw.Start();
QSort (array, 0, array.Length-1);
sw.Stop();
WriteLine(sw.ElapsedMilliseconds);
// Show(array);
// 15.CreateArray()
//   .Show(", ")
//   .QuickSort(0, 14)
//   .Show(", ");

