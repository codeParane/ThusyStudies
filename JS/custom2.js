let radian = prompt("Enter the radian : ", 0);
const pi = 22/7;

function area(_radian){
    document.write("run1");
    return (pi * _radian * _radian)
}

function diameter(_radian){
    document.write("run2");
    return (2 * pi * _radian)
}

document.write("Radian: "+ radian + " of Circle's Area: "+ area(radian) + " and Diameter is: " + 
diameter(radian));