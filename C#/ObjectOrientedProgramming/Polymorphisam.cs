using System;

namespace ObjectOrientedProgramming
{
    //polymorphisam

    //1 - static, compile time, early binding(method overloading, operator overloading
    //2 - dynamic, runtime, late binding(virtual , overriding method)

//Static - Method Overloading or functional overloading
class MethodOverLoading{
    void printWhatPass(string para){
        string msg = "Hi welcome to polymorphisam";
        Console.WriteLine("string pass {0}, {1}", para, msg);
    }
    void printWhatPass(double para){
        Console.WriteLine("Double Pass {0}", para);
    }
}

//static - operator overloading
class OperatorOverloading{
    void diffPara(int one){
        Console.WriteLine("One para Pass : {0}", one);
    }

    void diffPara(int one, int two){
        Console.WriteLine("Two para Pass : {0}, {1}", one, two);
    }
}

//Dynamic - Overriding
class Animal{
    public virtual void print(){
        Console.WriteLine("This is the Animal Class Print Method");
    }
}

class Dog: Animal{
    public override void print(){
        Console.WriteLine("This is tha Dog Class Print Method");
    }
}










}
    
    