import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DirectivesPipeParams';
  fontColor:string = "";
  today:Date = new Date(2022,0,30); 
  money:number = 150.990000000;
  percentage: number = 1;

  styles: object ={
    'font-size': this.fontColor === "YELLOW" ? '30px' : '12px'
  };
}
