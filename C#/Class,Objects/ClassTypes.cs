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
    //Base class, cant have an implementation, needs to extend for instantiate
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
    
    //just as normal class but restricted the inheritance 
    sealed class President{
        public President(){
            Console.WriteLine("Sealed class instantiated...");
        }  
    }

    //just as normal class but cant instantiate and inherite, can access properties and methods directly
    //because static class will instantiate when compiling 
    static class Government{
        public static void ruleNation(){
            Console.WriteLine("Government class instantiated...");
        }
    }
}



