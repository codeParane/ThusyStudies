using System;

namespace Class_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //object - instance of class 
            Vehicle car = new Vehicle(); 
            car.canRun();

         
        }
    }


    //Class - properties and methods that are used to represent a  real time entity
    // accessModifier class className{
    //  implementaiton
    // }
    class Vehicle
    {
        //proerties
        int engineCC;       //class variables
        string name;        //class variables

        //metods
        // accessModifier returnType methodName{
        //  implementaiton
        // }
        public void canRun(){
            Console.WriteLine("This Vehicle can Run");
        }
    }
   
}
