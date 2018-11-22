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

    abstract class Driver{
        string name = "Vehicles"; // can have an class variables
        public void speed(){
            Console.WriteLine(name + " All drivers have speed...");
        }
    }

    class CarDriver : Driver{
        public void carSpeed(){
            Console.WriteLine("Car driver have special speed....");
        }
    }

}



