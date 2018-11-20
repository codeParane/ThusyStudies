using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation : the Internal representation of an object is hidden from the view
            //outside object’s definition. Only the required information can be accessed whereas 
            //the rest of the data implementation is hidden.

            //encapsualation - Access Modifers
            atmAccount acc1 = new atmAccount();
            bool canWithraw = acc1.getPin(1234);
            if (canWithraw == true)
                Console.WriteLine("You can Withraw your money");
            else
                Console.WriteLine("Wrong Pin no your card will blocked");

            //encapsulation - Nested class
            BankSync bank1 = new BankSync();
            Console.WriteLine("Server Status : " + bank1.isServerConnect);

            //Polymorphisam :  one name, many forms multiple 
            //methods with the same name but different implementations.
            
            //Static/ Compile Time polymorphisam : same name but different implementation accoding to 
            //to different type or no of arguments
            Shapes circle = new Shapes();
            circle.area(7);

            Shapes rectangle = new Shapes();
            rectangle.area(4,5);


            //Dynamic/ run time Polymorphisam: same name same arguments but different implementaion 
            PrintBnW printer1 = new PrintBnW();
            printer1.print();

            PrintColor printer2 = new PrintColor();
            printer2.print();
            

            //Inheritance : ability to create new classes from another class. It is done by accessing, 
            //modifying and extending the behavior of objects in the parent class.
            // for more specify the objects

            //Parent Vehcile - Only Access class methods cant access childs
            Vehicle v1 = new Vehicle();
            v1.engine();

            //Car Child of Vechile - Can Access Class Method and Parent Class Methods
            Car v2 = new Car();
            v2.engine();
            v2.canDrift();

            //upcasting 
           
            //downcasting

            

        }
    }
}
