using System;

namespace Class_Objects
{
    //Partial Class - type of class dividing the properties and methods into multiple files
    //when compiling it compile as one class
    partial class partialClass
    {
        int num = 2304;
        public void print1()
        {
            Console.WriteLine("Partial class method 1 : " + num);
        }
    }
}



