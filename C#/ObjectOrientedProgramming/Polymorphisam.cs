using System;

namespace ObjectOrientedProgramming
{
    //polymorphisam
    //1 - static, compile time, early binding(method overloading, operator overloading)
    //2 - dynamic, runtime, late binding(virtual , overriding method)

    //compile time
    //same signature, diff types of parameter or diff no of parameters 
    

    class Shapes{
        //initial method - no arg method
        public int area(){
            return 1;
        }
        
        //over load with 1 argument
        public int area(int rad){
            return (22/7 * rad * rad);
        }

        //over load with 2 arguments
        public int area(int hei, int wid){
            return (hei * wid);
        }
        

        //diff type of arg
        public int area(double rad){
            
        }
    }















    
}