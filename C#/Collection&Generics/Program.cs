using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Array - (Fixed Length, Type Safe)
            int[] num = {1, 2, 3, 4, 5}; //5 (0-4)
            string[] seasons = {"Winter", "Summer", "Spring", "Autumn"};
            //num[2] -> 3, seasons[1] -> "Summer"       
        
            //Collection - (Auto Resize, not Type Safe)

            //ArrayList - FIFO (Index based)
            ArrayList Marks = new ArrayList(10); //Size : 0
            Console.Write("ArrayList Initial Capacity : " + Marks.Capacity);
            Marks.Add("StringValue");           //Size : 4
            Console.Write("\nArrayList After Adding 1 value Capacity : " + Marks.Capacity);
            Marks.Add(2);
            Marks.Add(3.456);
            Marks.Add(4);
            Marks.Add(true);   
            Console.Write("\nArrayList After Adding 4 value Capacity : " + Marks.Capacity); 

            //Hashtable <key, value> Pair
            Hashtable EmpDet = new Hashtable();
            EmpDet.Add("name", "Thusyanthy");   //name - #12edaw
            EmpDet.Add("job","Engineer");       //job -  #12edaz
            EmpDet.Add("s","qwerty");
            EmpDet.Remove("s");
            Console.Write(EmpDet["name"]);

            //Queue - FIFO (not indexed base)
            Queue q1 = new Queue();
            q1.Enqueue("Apple");
            q1.Dequeue();
            Console.Write(q1.Peek());

            //Stack - LIFO (not indexed base)
            Stack s1 = new Stack();
            s1.Push("A"); // add the top of stack
            s1.Peek(); //return the top of stack
            s1.Pop(); //delete and return the top value


            */
            //Generics - (Auto Resize , Type Safe)
            // List - 
            List<int> L1 = new List<int>();
            Console.Write("Initial Size : " + L1.Capacity);
            L1.Add(6);
            // L1.Add("String");   ERROR : cant accept another data types values;
            Console.Write("\nSize After Added 1 value : " + L1.Capacity);


            //Dictionary
            Dictionary<S?> d1 = new Dictionary();



        }
    }
}
//