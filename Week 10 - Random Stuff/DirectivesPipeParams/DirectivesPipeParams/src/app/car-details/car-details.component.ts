import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { car } from '../car';
import { CarsService } from '../cars.service';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.css']
})
export class CarDetailsComponent {
  carDisplay:car = {} as car;
  idCar: number = -1;
  constructor(private route:ActivatedRoute, private carService: CarsService){
    this.route.params.subscribe(params =>{
      this.idCar = +params['id'];

      //Normal this would be subscribe to, but this isn't hooking into an api but a set array
      this.carDisplay = this.carService.getCarById(this.idCar);
      console.log(this.carDisplay);
    })
  }
}
