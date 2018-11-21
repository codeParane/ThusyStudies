using System;

namespace Class_Objects
{
    //Access Modifiers
    class Employee
    {
        //Private - access only inside a class
        private int privateVar;
        public void getPrivate(int _privateVar)
        {
            //private variable can access here only
            privateVar = _privateVar;
        }

        //Public - access from every where within application and all assembly
        public int publicVar;
        public void getPublic(int _publicVar)
        {
            //public variable can access inside the class
            publicVar = _publicVar;
        }

        //Protected - can access within the class and inherited class members only
        protected int protectedVar;
        void getProtected(int _protectedVar)
        {
            protectedVar = _protectedVar;
        }
        //Internal - only access within the assembly
    }
    class OuterClass
    {
        void callAccess()
        {
            Employee e1 = new Employee();
            //public variable can access outside the class
            e1.publicVar = 20;
        }
    }
    class inheritClass : Employee
    {
        //protected variable can access from inherited class
        void callProtected()
        {
            Console.Write(protectedVar);
        }
    }
}

