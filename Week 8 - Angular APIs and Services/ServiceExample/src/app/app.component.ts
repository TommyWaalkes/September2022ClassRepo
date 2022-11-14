import { Component } from '@angular/core';
import { RandomNumberGenerationService } from './random-number-generation.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ServiceExample';

  output:number = 0; 

  //How Dependency is done in angular is that in the constructor for our component, 
  //We will create a private parameter, which Angular sees and knows to treat as a dependency injection 
  constructor(private rng: RandomNumberGenerationService){
    this.output = this.rng.GetRandomNumber(1,10);
  }

  //The job of this method is to delegate to our service
  GetRandomNum(min: number, max:number):number{
    return this.rng.GetRandomNumber(min, max);
  }

  UpdateOutput(){
    this.output = this.GetRandomNum(1,10);
  }
}
