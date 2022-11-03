//in JS if a function is inside of a class it is called a method 
//A function exists outside a class 

//If a variable is declared as part of a class and not simply a local variables 
//it is called a property. 

class Point{
    //classes can contain methods or properties 
    x; 
    y; 

    constructor(x,y){
        //While the this keyword is optional in C# 
        //it is mandatory in Javascript 
        //Scoping in JS is much more relaxed so we need to explictly say perform this action in a class
        this.x=x;
        this.y=y;
    }
    //Methods leave off the function keyword 
     CalcMidpoint(point){
        let midX = (this.x + point.x) / 2;
        let midY = (this.y + point.y) / 2;

        let midPoint = new Point(midX, midY);
        return midPoint;
     }
}

let p = new Point(5,5); 
let p2 = new Point(-2,-4);

//This much how C# obnjects call their methods 
let mid = p.CalcMidpoint(p2);

//I can print objects direclt in JS 
console.log(mid);