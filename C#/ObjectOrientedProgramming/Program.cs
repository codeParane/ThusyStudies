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
            Dog d1 = new Dog();
            d1.print();

            


        }
    }
}