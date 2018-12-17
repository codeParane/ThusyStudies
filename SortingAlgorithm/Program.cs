using System;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms...");
            int[] arr = { 4, 2, 1, 5, 3 };

        }

        static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int loc = arr[i];
                int j = i + 1;

                while (j >= 0 && arr[j] > loc)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = loc;
            } 
        }


        static void selectionSort(int[] arr)
        {
            //Finding the minimum element and putting to the begining of part????

            for (int j = 0; j < arr.Length; j++)
            {
                int minIndex = j;
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[minIndex])
                        minIndex = k;
                    
                    int tmp = arr[minIndex];
                    arr[minIndex] = arr[j];
                    arr[j] = tmp; 
            }}
        }

        static void printArray(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write("-" + arr[k]);
            }
        }
    }
}
