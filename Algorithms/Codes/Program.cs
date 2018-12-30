using System;

namespace Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 9, 4 };
            Console.Write("Before Sorting : ");
            printArray(num);

            //BubbleSort(num);
            InsertationSort(num);

            Console.Write(" | After Sorting : ");
            printArray(num);

        }
        //

        /*  Bubble Sort
            //1st Pass
            (3 5) 1 9 4
            3 (5 1) 9 4
            3 1 (5 9) 4
            3 1 5 (9 4)
            3 1 5 4 (9)  
            //2nd Pass

        */
        static void BubbleSort(int[] arr)
        {
            for (int j = 1; j <= arr.Length - 1; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            /* 
            3, 5, 1, 9, 4 
            smVal= 1, smIdx= 2 -> arr[0] swap arr[smIdx]
            1, 5, 3, 9, 4
            -, 5, 3, 9, 4
            smVal=3, smIdx=2 -> arr[1] swap arr[smIdx]
            1, 3, 5, 9, 4
            -, -, 5, 9, 4
            smVal= 4, smIdx= 4 -> arr[2] swap arr[smIdx]
            1, 3, 4, 9, 5
            -, -, -, 9, 5
            smVal= 5, smIdx=4 -> arr[3] swap arr[smIdx]
            1, 3, 4, 5, 9
            */
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minIdx = i; //arr[0]
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                int tmp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = tmp;
            }
        }

        static void InsertationSort(int[] arr){
            /*
            3 5 1 9 4
            3 5 1 9 4 
            3 1<5 9 4 
            3<1 5 9 4
            135 9 4 
            
             */
            for(int i=1;i<arr.Length;i++){
                //value =5 = arr[1], holeIdx= 1
                int value = arr[i];
                int hole = i;
                while(hole>0 && arr[hole-1]>value){
                    arr[hole] =  arr[hole-1];
                    hole = hole-1;
                }
                arr[hole] = value; 
            }
        }






        static void printArray(int[] _array)
        {
            foreach (int item in _array)
            {
                Console.Write(" " + item);
            }
        }
    }
}

