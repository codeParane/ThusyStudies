//Modern mode get a latest version 
"use Strict";
//Print on the document
document.write("<br>Hello World!"); document.write("<br>Welcome");

//variable declaration 
var name = "Hello";
let name2 = "Hi";

// Loosly Typed language
document.write("<br><br>String Variables : " + name);
name = 2;
document.write("<br>Integer Variables : " + name);
name2 = ["Apple", "Orange"];
document.write("<br>First Element in Array : " + name2[0]);

//constant
const pi = 22/7;
document.write("<br><br>Before Change PI : " + pi);
// pi=2; cant change on the fly if assighned it will error.
document.write("<br>After Change PI : " + pi);


//data types - Number, String, Boolean, Null, array, undefined
let vNumber= 123; //1.23 , -12
let vString = "Hello";
let vBoolean = true;
let vArray = ["Apple", "Mango", "Orange"];
let vNull = null;

document.write("<br><br>Integer: "+ vNumber +" ,String: "+ vString +" ,Boolean: "+ vBoolean +" ,Array: "+ 
vArray +" ,Null: "+ vNull +".");

//typeOf() will output what type of data is stored at that point
document.write("<br><br>"+ vNumber + " is type of " + typeof(vNumber));

//Type Convertion convert variable to one data type to another
let str = 123;
document.write("<br><br>123 typeOf before Change: "+ typeof(str));
str = String(str)
document.write(" - 123 typeOf after Change: "+ typeof(str));

let str2 = "123";
document.write("<br>Apple typeOf before Change: "+ typeof(str2));
str2 = Number(str2)
document.write(" - Apple typeOf after Change: "+ typeof(str2));

let str3 = "1";
document.write("<br>1 typeOf before Change: "+ typeof(str3));
str3 = Boolean(str3)
document.write(" - 1 typeOf after Change: "+ typeof(str3));

let str4 = "0";
document.write("<br>0 typeOf before Change: "+ typeof(str4));
str4 = Boolean(str4)
document.write(" - 0 typeOf after Change: "+ typeof(str4));

//Operators
// +, -, /, *, ++, -- , +=, -=, *=, /=
// &, |

//Comparision
//a > b, a < b, a >= b, a <= b, a == b, a != b, 

//Strict Equality
// a === b  Check value and type, a == b Check value only not type
let a = "2";
let b = 2;
document.write("<br><br> a == b : " + (a==b)); //true
document.write("<br> a === b : " + (a===b));  //false

//Interaction
//alert("alert Box!");

// let year = prompt("Enter the Current Year ?", 2018);
// alert("You Entered: " + year);

// let ans = confirm("Do you like Apple?");
// alert("You Liked Apple : " + ans);

//if, switch, ?-ternary   ->    a>b?true:false
//Ternary Operator
let numb = 18;
let isAbove20 = numb > 20 ? "yes" : "no";

// if(numb > 20){
//     isAbove20 = "yes"; 
// }else{
//     isAbove20 = "no";
// }

//do, while, for, foreach

function myf(name){
    alert(name);
}