using System;
public class Patterns
{
    public void print1()
    {
        //*****
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("*");
        }
    }
e
    public void print2()
    {
        /*
        *
        *
        *
        *
        *
        */
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("*");
        }
    }
    public void print3()
    {
        /*
        1
        12
        123
        1234
        12345
         */
        for (int k = 1; k <= 5; k++)
        {
            for (int l = 1; l <= k; l++)
            {
                Console.Write(l);
            }
            Console.WriteLine("");
        }
    }
    public void print4(){
        /*
        
         */
    }









}