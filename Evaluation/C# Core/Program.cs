using System;

namespace C__Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1 - 
            Console.WriteLine("Enter the animal to get it's sound....");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.Write("Bow Bow.....");
                    break;
                case "cat":
                    Console.Write("Meyow Meyow....");
                    break;
                case "cow":
                    Console.Write("Ma Ma.....");
                    break;
                case "goat":
                    Console.Write("mae mae.....");
                    break;
                default:
                    Console.Write("sound.....");
                    break;
            }

            //Q2
            Console.WriteLine("Enter the number to print the pattern....");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                for (int j = num; j >= i; j--)
                    Console.Write(j);
                Console.WriteLine();
            }

            //3
            string month = "January";

            if (month == "mar" || month == "apr" || month == "may")
                Console.WriteLine("Its a Spring Season...");
            else if (month == "jun" || month == "jul" || month == "aug")
                Console.WriteLine("Its Summer Season....");
            else if (month == "sep" || month == "oct" || month == "nov")
                Console.WriteLine("Its Autumn Season.....");
            else if(month == "dec" || month == "jan" || month == "feb")
            Console.WriteLine("Its Winter Season....");



            //4




            //5

            /*  */
        }
    }
}
