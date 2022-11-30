import { Injectable } from '@angular/core';
import { car } from './car';

@Injectable({
  providedIn: 'root'
})
export class CarsService {
  cars: car[] =[
    {id:0, make:"Ford", model:"Fiesta", mileage:50000, year: 2019}, 
    {id:1, make:"Toyota", model:"Avalon", mileage:400000, year: 1998},
    {id:2, make:"GM", model:"Goose", mileage:400, year: 2022}
  ]
  constructor() { }

  getAllCars():car[]{
    return this.cars;
  }

  getCarById(id:number):car{
    //Lets assume each id is unique like in SQL, in our fullstack that's part of SQL's job
    for(let i: number = 0; i < this.cars.length; i++){
      let c : car = this.cars[i];
      if(c.id === id){
        return c;
      }
    }

    let emptyCar: car = {} as car;
    emptyCar.make ="No car found at id of " + id;

    return emptyCar;
  }
}
