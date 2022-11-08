//you'll see duplicate errors on your class names , you can safely ignore that if your code is able to run
class Circle{
    //varName : datatype; 
    //this is how you declare datatypes in typescript
    radius : number;
    bigEnough : boolean;
    creator : string;

    constructor(radius: number, bigEnough:boolean, creator:string  ){
        this.bigEnough = bigEnough; 
        this.radius = radius;
        this.creator = creator;
    }

    GetArea():number {
        let area : number = Math.PI * this.radius * this.radius;
        return area;
    }
}

let c : Circle = new Circle(10, true, "Tommy");

console.log(c.GetArea());