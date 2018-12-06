using System;
using System.Threading;

namespace MultiThreading
{
    class lockSmpl
    {
        
        Thread t1 = new Thread(run);
        Thread t2 = new Thread(run);

        public static int num=0;

        
        static void run(){
            while(num < 10){
                Console.WriteLine("Before : " + num);
                num++;
                Console.WriteLine("After : "+ num);
            }
        }
    }
}