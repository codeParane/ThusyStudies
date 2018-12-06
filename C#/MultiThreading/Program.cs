using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        //main thread
        //foreground thread - thread which is continuely run even main thread alive or not.
        //background thread - thread which exit when main thread exit.
        static void Main(string[] args)                 //main thread start to execute
        {

            Thread t1 = new Thread(run);
            Thread t2 = new Thread(run);
            t1.Start();
            t2.Start();

        }

        public static int num = 0;


        static void run()
        {
            while (num < 10)
            {
                Console.WriteLine("Before : " + num);
                num++;
                Console.WriteLine("After : " + num);
            }
        }


        //main thread end to execute
    }
}
