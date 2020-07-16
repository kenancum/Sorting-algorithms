using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatchMerge = new Stopwatch();
            Stopwatch stopWatchCount = new Stopwatch();
            Stopwatch stopWatchQuick = new Stopwatch();


            int[] arr = ArrayGenerator.GenerateRandomArray(15);
            int n =arr.Length;
            int[] initialArr = arr;

            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(initialArr[i] + " ");
            }
            Console.WriteLine();

            stopWatchMerge.Start();
            ArrayGenerator.mergeSort(arr, 0, n - 1);
            stopWatchMerge.Stop();
            long ticks = stopWatchMerge.ElapsedTicks;

            Console.Write("\nMerge sorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Time: "+ ticks);
            Console.WriteLine();



            stopWatchCount.Start();
            int[] countSort = ArrayGenerator.CountingSort(arr);
            stopWatchCount.Stop();

            ticks = stopWatchCount.ElapsedTicks;
            Console.Write("\nCount sorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(countSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Time: " + ticks);
            Console.WriteLine();


            
            int[] quickSort = arr;

            stopWatchQuick.Start();
            ArrayGenerator.quickSort(arr, 0, n - 1);

            stopWatchQuick.Stop();

            ticks = stopWatchQuick.ElapsedTicks;

            Console.Write("Quick sorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(quickSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Time: " + ticks);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
