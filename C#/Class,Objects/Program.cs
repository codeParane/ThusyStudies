using System;

namespace Class_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Class&Obj.cs - Class and methods
            //object - instance of class 
            Vehicle car = new Vehicle();
            car.canRun();
            */

            /*
            //Interface.cs  - initilization
            Student s1 = new Student();
            s1.canLearn();
            Console.WriteLine("is student passed ? " + s1.isPassed());
            //cant initlize the object from interface 
            // IStudent is1 = new IStudent();
            */

            /* 
            //Constructor
            ClsConstructor c1 = new ClsConstructor();
            ClsConstructor c2 = new ClsConstructor(20);
            GC.Collect();
            */

            /* 
            //Single Object needs to instantiate - for partial class
            partialClass p1 = new partialClass();
            p1.print1();
            p1.print2();
            */

            //cant instantiate directly from abstract class
            // Driver d1 = new Driver();

            //need another class for extend from abstract class
            CarDriver c1 = new CarDriver();
            c1.speed();
            c1.carSpeed();
        }
    }
}