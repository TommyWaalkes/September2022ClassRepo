import { Component } from '@angular/core';
import { car } from '../car';
import { CarsService } from '../cars.service';

@Component({
  selector: 'app-carlist',
  templateUrl: './carlist.component.html',
  styleUrls: ['./carlist.component.css']
})

export class CarlistComponent {
  cars:car[] =[];
  constructor(private carService:CarsService)
  {
    //if this were connected to an API we'd need to subscribe to the method, 
    //but this all coming from a hard coded car array
    this.cars = this.carService.getAllCars();
  }
}
