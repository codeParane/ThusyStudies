using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Encapsulation - getter setter with condtitions
            BankServer bank1 = new BankServer();
            Console.WriteLine("Current ip : " + bank1.getServerIp("Banker1"));
            bank1.setServerIp("Banker1", "192.168.1.2");
            Console.WriteLine("Current ip : " + bank1.getServerIp("Banker1"));
            */

            /* 
            //Encapsulation - nested Class
            Account c1 = new Account();
            */

            /* 
            //Inheritance
            //parent class object
            Telephone t1 = new Telephone();
            t1.itsPhone();
            t1.canMakeCall();
            //child Class Object
            HandPhone h1 = new HandPhone();
            h1.itsPhone();
            h1.canMakeCall();
            */

            //Call overloading methods
            Shapes empty = new Shapes();
            Console.WriteLine("no arg method called : " + empty.area());
            //Call overloading methods
            Shapes circle = new Shapes();
            Console.WriteLine("1 arg method called : " + circle.area(7));
            //Call overloading methods
            Shapes rectangle = new Shapes();
            Console.WriteLine("2 arg method called : " + rectangle.area(8,4));

            


        }
    }
}