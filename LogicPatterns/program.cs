using System;

namespace LogicPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 1, 4, 5, 7, 6 };
            int[] num2 = { 2, 1, 4, 7 };
            // int[] num3 = {121, 1234, 12344321, 5445};
            int num4 = 12321;

            printPalin(num4);
             
            //findValue(num, num2);
            // find2ndMax(num);
            // findMax(num);
            // findMin(num);
        }


        //print the palindrome number from an array
        static void printPalin(int _num){
            // needs to write the logic true > its a palindrome, false > its not a palindrome
            
        }






        //return the values which are not in 2 nd array from 1st array
        static void findValue(int[] _arr1, int[] _arr2)
        {
            for (int i = 0; i < _arr1.Length; i++)
            {
                bool isAvail = false;
                for (int j = 0; j < _arr2.Length; j++)
                {
                    if (_arr1[i] == _arr2[j])
                        isAvail = true;
                }
                if (isAvail == false)
                    Console.WriteLine(_arr1[i]);
            }
        }

        //find the second max value
        static void find2ndMax(int[] _num)
        {
            int max = _num[0];  //2
            int secondMax = _num[0];  //2

            for (int i = 0; i < _num.Length; i++)
            {
                if (max < _num[i])
                {
                    secondMax = max;                //2 = 2, 2=4,
                    max = _num[i];                  //2 = 4, 4=5,

                }
                else if (secondMax < _num[i])
                {
                    secondMax = _num[i];        //2=4
                }

            }
            Console.WriteLine("Second max value : " + secondMax);
        }

        //find the max
        static void findMax(int[] _num)
        {
            int max = _num[0];
            for (int i = 0; i < _num.Length - 1; i++)
            {
                if (max < _num[i + 1])
                    max = _num[i + 1];
            }

            Console.WriteLine("Find the maximum : " + max);
        }

        //find the min
        static void findMin(int[] _num)
        {
            int min = _num[0];
            for (int j = 0; j < _num.Length - 1; j++)
            {
                if (min > _num[j + 1])
                    min = _num[j + 1];
            }

            Console.WriteLine("Find the minimum : " + min);
        }

    }
}
