using System;

namespace OOP
{
    //polumorphisam - override
    class Print
    {
        public virtual void print()
        {
            Console.WriteLine("Print");
        }
    }
    class PrintBnW : Print
    {
        public override void print()
        {
            Console.WriteLine("Black and White Print");
        }
    }

    class PrintColor: Print
    {
        public override void print()
        {
            Console.WriteLine("Color Print");
        }
    }

    //polymorphisam - overload
    class Shapes{
        public void area(int _radian){
            Console.WriteLine("Circle Area is : " + (22/7*_radian));
        }
        public void area(int _width, int _height){
            Console.WriteLine("Rectangele Area is : "+(_width * _height));
        }
    }
}