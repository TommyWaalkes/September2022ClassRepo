
//What are interface and why are they needed in Angular? 
//Interfaces are like classes - they can define properties, but unlike classes 
//They may NOT add functions or properties at run time <- prevent random functions from somehow sneaking their into our code
//Interfaces do not have constructors
//Angular loves intefaces since they will behave consistently and it side steps a lot of common JS errors/weird behavior
//With interfaces every property MUST get a value
interface Mountain{
    name:string;
    height:number;
}

//We must use this syntax since interfaces cannot use constructors
//This is called object literal syntax, we make an object and store it in 
//A mountain variable which conveerts from a generic object to a Mountain 
let m :Mountain = {name:"Everest", height:29000};
console.log(m);