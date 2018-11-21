using System;

namespace Class_Objects
{

    //Interface - Specification for the object, cant have an implementation
    interface IStudent
    {
        void canLearn();
        bool isPassed();
    }

    //Implementation for interface must have all the immplementation for the method which specified in Interface
    class Student : IStudent
    {
        public void canLearn()
        {
            Console.WriteLine("Student can Learn !!!");
        }

        public bool isPassed()
        {
            return true;
        }
    }
}

