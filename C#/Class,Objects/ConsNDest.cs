using System;

namespace Class_Objects
{
    class ClsConstructor
    {
        //if there is no constructor class loader generate the empty constructor for the class
        /*
        ClsConstructor(){
            
        }
        */
        //default constructor 
        public ClsConstructor()
        {
            Console.WriteLine("construtor initilized...");
        }
        public ClsConstructor(int no){
            Console.WriteLine("para int constructor initilized...");
        }

        //destructor 
        ~ClsConstructor(){
            Console.WriteLine("distructor initilized...");
        }    
        
    }
}