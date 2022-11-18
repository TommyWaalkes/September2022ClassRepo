import { Component } from '@angular/core';
import { DonutResults } from './DonutResults';
import { DonutsService } from './donuts.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DonutsNDev';

  constructor(private donutApi: DonutsService){
    this.donutApi.GetAllDonuts().subscribe(
      (result:DonutResults) => {
        console.log(result);
      }
    );
  }
}
