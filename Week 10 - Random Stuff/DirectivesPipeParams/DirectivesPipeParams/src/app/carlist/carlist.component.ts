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
    this.cars = this.carService.getAllCars();
  }
}
