using System;

namespace Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 12, 23, 1, 45, 9 };
            Console.Write("Before Sorting :");
            printArray(num);

            //Selection Sort
            for (int i =0; i < num.Length - 1; i++){
                int minIndx = i;
                for(int j=i+1;j<num.Length;j++){
                    if(num[j] < num[minIndx] ){
                        minIndx = j;
                    }
                }
                int tmp = num[minIndx];
                num[minIndx] = num[i];
                num[i] = num[minIndx];
            }
            Console.WriteLine();
            printArray(num);

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
