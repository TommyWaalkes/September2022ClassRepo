//While JS has classes (they were added in around 2015) code can exist outside of them and often does. 
//When a JS is imported any code not inside a class or function, gets run from top to bottom
console.log("Welcome to our room calculator"); 

let width = prompt("Please input a width");
let length = prompt("Please input a length");

let area = width * length;

//This is how JS does string interpolation 
console.log(`Area: ${area}`)

let perimeter = 2 * width + 2* length;

console.log(`Perimeter: ${perimeter}`)