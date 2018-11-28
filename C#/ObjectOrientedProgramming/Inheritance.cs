using System;

namespace ObjectOrientedProgramming
{
    //Inheritance - down -> more Specifying the objects, up -> generalization
    //Characteristics are inherit from ancestor

    class Telephone{
        public void itsPhone(){
            Console.WriteLine("Its a Telephone......");
        }

        public void canMakeCall(){
            Console.WriteLine("Can make noraml Call Only......");
        }

    }
    
    class HandPhone: Telephone{
        public void call(){
            Console.WriteLine("Hand phone Call...");
        }
    }
    class LandPhone: Telephone{
        public void call(){
            Console.WriteLine("Land Phone Call....");
        }
    }

    class IPhone: HandPhone{
//? Page13 missing 
    }
    

}
