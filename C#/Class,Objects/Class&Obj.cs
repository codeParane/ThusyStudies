using System;

namespace Class_Objects
{
    //Class - properties and methods that are used to represent a  real time entity
    // accessModifier class className{
    //  implementaiton
    // }
    class Vehicle
    {
        //proerties
        int engineCC = 3500;       //class variables
        string name = "BMW320d";        //class variables

        //metods
        // accessModifier returnType methodName{
        //  implementaiton
        // }
        public void canRun()
        {
            Console.Write(name + " - " + engineCC);
            Console.WriteLine("This Vehicle can Run");
        }
    }

}
