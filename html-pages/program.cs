using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };

            BubbleSort(arr);
            InsertionSort(arr);
            Console.ReadKey();
        }

        private static void InsertionSort(int[] arr)
        {
            int compareCount = 0;
            int insertCount = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int val = arr[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    compareCount++;

                    if (val > arr[j])
                    {
                        insertCount++;

                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Compare : " + compareCount);
            Console.WriteLine("Insert : " + insertCount);
        }

        private static void BubbleSort(int[] arr)
        {
            int compareCount = 0;
            int insertCount = 0;

            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    compareCount++;
                    if (arr[i] < arr[i + 1])
                    {
                        insertCount++;
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Compare : " + compareCount);
            Console.WriteLine("Insert : " + insertCount);
        }
    }
}
