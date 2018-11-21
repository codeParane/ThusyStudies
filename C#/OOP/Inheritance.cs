using System;

namespace OOP
{
    class Vehicle
    {
        public virtual void engine()
        {
            Console.WriteLine("I have an Engine!");
        }
    }

    class Car : Vehicle
    {
        public void canDrift()
        {
            Console.WriteLine("I can Drift");
        }
        public new void engine(){
            Console.Write("I have a car engine");
        }
    }
    class Ship : Vehicle
    {
        public void canSink()
        {
            Console.WriteLine("I can Sink");
        }
    }
}