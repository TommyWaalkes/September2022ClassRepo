import { Injectable } from '@angular/core';


//all services in Angular need to be set to be injectable 
//This allows the class to be used in Dependency Injection 
@Injectable({
  providedIn: 'root'
})
export class RandomNumberGenerationService {

  constructor() { }

  //I just have to get the formula right here and then I pass it to whatever components I wish 
  GetRandomNumber( min:number, max:number):number{
    return Math.floor(Math.random() * max) + min;
  }
}
