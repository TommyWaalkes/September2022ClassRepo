class Student{
    name; 
    homeTown; 
    favoriteFood;

    constructor(name, homeTown, favoriteFood){
        this.name = name; 
        this.homeTown = homeTown;
        this.favoriteFood = favoriteFood;
    }
}

//This tells JS this is an array 
//Arrays in JS are loosely typed - any data type can go in and any data type can come out 
//Generally to save our sanity, we try to only put 1 type into arrays in JS. 
//JS Arrays are flexibly sized - they shrink and grow to fit the data inside them 
//They are still indexed starting at 0 
//Otherwise the syntax should look pretty familar 
students = [];

students[0] = new Student("Jimmy Buffet", "Space Texas", "Space shrimp with Earth Grits");
students[1] = new Student("Polly Parfait", "Space New York State", "Rice Omelettes"); 
students[2] = new Student("Andy Anchovy", "Future Boston", "Ham Sandwhiches");

//a string + anything makes everything into a string, usually 
let pick = prompt("Please select a student from the list to learn about: 0 to "+(students.length - 1));

let stu = students[pick];
console.log(stu);

let topic = prompt(`What would you like to learn about ${stu.name}? hometown or favoriteFood`); 

if(topic === "hometown"){
    console.log(stu.homeTown);
}
else if(topic === "favoriteFood"){
    console.log(stu.favoriteFood);
}