using System;

namespace OOP
{
    class Vehicle
    {
        public void engine()
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
    }
    class Ship : Vehicle
    {
        public void canSink()
        {
            Console.WriteLine("I can Sink");
        }
    }
}